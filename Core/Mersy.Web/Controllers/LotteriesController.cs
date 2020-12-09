namespace Mersy.Web.Areas.Administration.Controllers
{
    using CommonTasks.Data;
    using Mersy.Common.Entities;
    using Mersy.Common.Helpers;
    using Mersy.Common.Models;
    using Mersy.Infraestructure;
    using Mersy.Infraestructure.Extensions;
    using Mersy.Repositories.Implementations.Cor;
    using Mersy.Web.Controllers;
    using Mersy.Web.Helpers;
    using Mersy.Web.Hubs;
    using Mersy.Web.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.SignalR;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    [Authorize(Roles = "Admin,SuperUser,Seller")]
    public class LotteriesController : PsBaseController
    {
        private readonly LotterySaleRepository _repository;
        private readonly IHubContext<NotificationHub> _notificationHubContext;

        public LotteriesController(ApplicationDbContext context, IUserHelper userHelper,
            ICurrentUserFactory currentUser,
            IServiceProvider serviceProvider, LotterySaleRepository lotterySaleRepository,
             IHubContext<NotificationHub> notificationHubContext) : base(context, userHelper, currentUser, serviceProvider)
        {
            _notificationHubContext = notificationHubContext;
            _repository = lotterySaleRepository;
        }

        [Authorize(Roles = "Seller")]
        public async Task<ActionResult> SellNumbers(int? id, int? personId)
        {
            var userId = await GetUserAsync();
 
            var myMainElement = new LotteryTicketView // LotterySale
            {
            };

            await FillLotteryAndLotteryModeCombo();

            var lotteriesAvailables = new List<Lottery>
            {
                new Lottery { Id = 0, Name = "-- Seleccione una Loteria" }
            };

            var clasifications = await _repository.GetLotteriesAvailableToSell(MyCurrentUser.Get.OwnerId);// await Context.Lotteries.Where(p => p.CreatedUser.Owner == authorid).OrderBy(p => p.Name).ToListAsync();
            lotteriesAvailables.AddRange(clasifications);

            ViewBag.LoteryTypes = lotteriesAvailables;

            if (id != null)
            {
                var existingSale = await _repository.GetTicketAsync(id.Value);

                if (existingSale != null)
                {
                    myMainElement.Id = existingSale.Id;
                    myMainElement.LotterySaleItems = existingSale.LotterySaleItems;
                    myMainElement.TotalAmount = existingSale.TotalAmount;
                }
            }

            return View(myMainElement);
        }

        [HttpPost]
        public async Task<IActionResult> SaveSales([FromBody] LotterySale sell) //LotterySale sell.LotterySale, List<LotterySaleItem> items)
        {
            bool status = false;
            long idi = 0;
            var msg = string.Empty;
            var openUrl = "";

            if (!ModelState.IsValid) return new JsonResult(new { status, idi, msg = "Modelo Invalido" });

            var userId = await GetUserAsync();

            var response = await _repository.SaveSale(sell, MyCurrentUser.Get.OwnerId, userId);
            if (!response.IsSuccess)
                return new JsonResult(new { status, idi, msg = response.Message });

            try
            {

                status = true;
                idi = sell.Id;

                openUrl = Url.Action("PrintTicket", new { id = idi });
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                status = false;
            }

            return new JsonResult(new { status, idi, msg, openUrl });

        }

        [Authorize(Roles = "Seller")]
        public async Task<IActionResult> PayPrize(long id)
        {
            var model = await _repository.GetByIdAsync(id); //await Context.LotterySales.FindAsync(id);

            if (model == null || model.WasPaid)
                return NotFound();

            var userId = await GetUserAsync();
            var response = await _repository.PayPrizedTicket(model, userId);
            if (!response.IsSuccess)
                return RedirectToAction("ErrorPage", "Home", new { area = "", message = response.Message });

            return RedirectToAction(nameof(PayTickets));
        }

        [Authorize(Roles = "Seller")]
        [HttpPost]
        public async Task<IActionResult> TicketsToBePaid(string date, string ticket = "", string user = "")
        {
            DateTime dt = Dates.ConverToDate(date, "es-DO");
            var tickets = await _repository.GetTicketsAsync(MyCurrentUser.Get.OwnerId, dt, false, ticket, user, false, false, 0);

            return PartialView("_TicketToBePaidPartial", tickets);
        }

        [Authorize(Roles = "Seller")]
        public async Task<IActionResult> PayTickets(string ticket = "", string user = "")
        {
            var date = DateTime.Now;
            await FillUserCombo();

            var tickets = await _repository.GetTicketsAsync(MyCurrentUser.Get.OwnerId, date, false, ticket, user, false, true, 0);

            return View(tickets);
        }

        private async Task FillUserCombo()
        {
            ViewData["Users"] = new SelectList(await _repository.GetUsersForCombo(MyCurrentUser.Get.OwnerId), "Id", "FullName");
        }

        [Authorize(Roles = "Seller")]
        [HttpPost]
        public async Task<IActionResult> GetItemsToDisplayDetail(string playedNumber, long lotteryId, long modeId)
        {
            var owner = MyCurrentUser.Get.OwnerId;
            var plays = await _repository.GetPlaysFilter("", owner, modeId, playedNumber, lotteryId, DateTime.Now);
            var vm = new PlayViewModel();
            vm.Sale = new LotterySale();
            vm.Items = plays;
            vm.Number = playedNumber;
            var lttery = await _repository.GetLotery(lotteryId);
            vm.Lottery = lttery.Name;
            var mode = await _repository.GetMode(modeId);
            vm.Mode = mode.Code;
            return PartialView("_TicketDetailsByNumberPartial", vm);
        }

        [Authorize(Roles = "Seller")]
        [HttpPost]
        public async Task<IActionResult> GetTicketToDisplayDetail(long ticketId)
        {
            var play = await _repository.GetTicketAsync(ticketId);
            var vm = new LotterySaleView();
            vm.Sales = new List<LotterySale>();
            vm.Sale = play;
            return PartialView("_TicketDetailsPartial", play);
        }

        [Authorize(Roles = "Seller")]
        [HttpPost]
        public async Task<IActionResult> MonitoringPlaysFilterx(long mode = 0, string play = "", long lottery = 0, string date = "")
        {
            DateTime df = Dates.ConverToDate(date, "es-DO");

            var plays = await _repository.GetPlays(MyCurrentUser.Get.UserId, MyCurrentUser.Get.OwnerId, mode, play, lottery, df, df);
            return PartialView("_PlayPartial", plays);
        }

        public async Task<IActionResult> MonitoringPlays(long mode = 0, string play = "", long lottery = 0, string date = "")
        {
            DateTime df = Dates.ConverToDate(date, "es-DO");

            var plays = await _repository.GetPlays(MyCurrentUser.Get.UserId, MyCurrentUser.Get.OwnerId, mode, play, lottery, df, df);

            await FillLotteryAndLotteryModeCombo();
            var vm = new PlayViewModel();
            vm.Sale = new LotterySale();
            vm.Items = plays;
            return View(vm);
        }

        private async Task FillLotteryAndLotteryModeCombo()
        {
            ViewData["LotteryModes"] = new SelectList(await _repository.GetModesForCombo(), "Id", "Name");
            ViewBag.LotteryModesx = await Context.LotteryModes.ToListAsync();
            ViewData["Lotteries"] = new SelectList(await _repository.GetLotteriesForCombo(), "Id", "Name");
        }

        [HttpPost]
        public async Task<IActionResult> MonitoringTicketsFilterx(string date, string ticket = "", string user = "", int status = 0)
        {
            DateTime df = Dates.ConverToDate(date, "es-DO");
            var tickets = await _repository.GetTicketsAsync(MyCurrentUser.Get.OwnerId, df,
                true, ticket, user, false, true, 0, status);

            var vm = new LotterySaleView();
            vm.Sales = tickets;
            return PartialView("_TicketPartial", vm);
        }

        public async Task<IActionResult> MonitoringTickets(string ticket = "", string user = "", int status = 0)
        {
            var date = DateTime.Now;
            await FillUserCombo();

            var tickets = await _repository.GetTicketsAsync(MyCurrentUser.Get.OwnerId, date, true,
                ticket, user, false, false, 0, status);
            var vm = new LotterySaleView();
            vm.Sales = tickets;
            vm.Sale = new LotterySale();
            return View(vm);
        }

        public async Task<ActionResult> PrintTicket7(long id)
        {
            var ticket = await _repository.GetTicketAsync(id);
            var vm = new Common.Models.LotteryTicketView();
            ticket.Transfer(ref vm, null, false);
            return View(vm);
        }

        public async Task<ActionResult> PrintTicket6(long id)
        {
            var ticket = await _repository.GetTicketAsync(id);
            var vm = new LotteryTicketView();
            ticket.Transfer(ref vm, null, false);
            return View(vm);
        }

        public async Task<ActionResult> PrintTicket5(long id)
        {
            var ticket = await _repository.GetTicketAsync(id);
            var vm = new LotteryTicketView();
            ticket.Transfer(ref vm, null, false);
            return View(vm);
        }

        public async Task<ActionResult> PrintTicket4(long id)
        {
            var ticket = await _repository.GetTicketAsync(id);
            var vm = new LotteryTicketView();
            ticket.Transfer(ref vm, null, false);
            return View(vm);
        }

        public async Task<ActionResult> PrintTicket3(long id)
        {
            var ticket = await _repository.GetTicketAsync(id);
            var vm = new LotteryTicketView();
            ticket.Transfer(ref vm, null, false);
            return View(vm);
        }

        public async Task<ActionResult> PrintTicket2(long id)
        {
            var ticket = await _repository.GetTicketAsync(id);
            var vm = new LotteryTicketView();
            ticket.Transfer(ref vm, null, false);
            return View(vm);
        }

        [AllowAnonymous]
        public async Task<ActionResult> PrintTicket(long id)
        {
            var ticket = await _repository.GetTicketAsync(id);
            LotteryTicketView vm = _repository.TicketForPrinter(ticket);

            return View(vm);
        }

        private async Task LoadLocalSelectListAsync(LotteryResult model)
        {
            ViewData["Loteries"] = new SelectList(await _repository.GetLotteriesForCombo(), "Id", "Name", model.LotteryId);
        }

        [HttpPost]
        public async Task<IActionResult> FilterSelledTicket(long lotterySaleId)
        {
            var item = await _repository.GetTicketsAsync(MyCurrentUser.Get.OwnerId, DateTime.Now, true, "", "", false, false, lotterySaleId);
            var sale = item.FirstOrDefault();
            var vm = new LotteryTicketView();
            sale.Transfer(ref vm, null, false);

            return PartialView("_PrintSelledTicket", vm);
        }

        public ActionResult ToAnulated()
        {
            var anulationsRequest = _repository.GetAnulatedSol(MyCurrentUser.Get.OwnerId);

            return View(anulationsRequest);
        }

        public async Task<IActionResult> DeleteTicket(long id)
        {
            var response = await _repository.DeleteTicketSol(id);
            if (!response.IsSuccess)
                return RedirectToAction("ErrorPage", "Home", new { area = "", message = response.Message });
            await _notificationHubContext.Clients.All.SendAsync("sendToUser", "hi,", "xx");

            return RedirectToAction(nameof(MonitoringTickets));
        }
        public async Task<IActionResult> AdminNoDeleteTicket(long id)
        {
            var response = await _repository.NoDeleteTicket(id);
            if (!response.IsSuccess)
                return RedirectToAction("ErrorPage", "Home", new { area = "", message = response.Message });
            await _notificationHubContext.Clients.All.SendAsync("sendToUser", "hi,", "xx");

            return RedirectToAction(nameof(ToAnulated));
        }
        public async Task<IActionResult> AdminDeleteTicket(long id)
        {
            var response = await _repository.DeleteTicket(id);
            if (!response.IsSuccess)
                return RedirectToAction("ErrorPage", "Home", new { area = "", message = response.Message });
            await _notificationHubContext.Clients.All.SendAsync("sendToUser", "hi,", "xx");

            return RedirectToAction(nameof(ToAnulated));
        }

        [HttpPost]
        public async Task<IActionResult> ResultsFilter(string date)
        {
            var cdate = Dates.FormatedDate(date);
            var vm = await _repository.GetResultsFromDate(cdate, MyCurrentUser.Get.OwnerId);

            return PartialView("_LoterryResultPartial", vm);
        }

        public async Task<IActionResult> Results(string indicator = "")
        {
            var date = DateTime.Now;
            var vm = await _repository.GetResultsFromDate(date, MyCurrentUser.Get.OwnerId);
            vm.Indicator = indicator;
            indicator = "";
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterResult(ResultsViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            var result = await _repository.RegisterResultAsync(vm, MyCurrentUser.Get.OwnerId);
            if (!result.IsSuccess)
            {
                ModelState.AddModelError("", result.Message);
                vm.Indicator = result.Message;
                return View("Results", vm);
            }
            return RedirectToAction(nameof(Results), new { indicator = "Saved" });
        }

        public async Task<IActionResult> Index()
        {
            var modelList = await _repository.GetLoteries();

            return View(modelList);
        }

        public async Task<IActionResult> Details(long id)
        {
            var model = await _repository.GetLotery(id);

            if (model == null)
            {
                return NotFound();
            }

            var vm = new LotteryViewModel();
            model.Transfer(ref vm, null, false);
            vm.CloseMonday = model.LotterySchedules.Where(p => p.DayOfTheWeek == 1).FirstOrDefault().CloseHour;//.ToLocalTime();
            vm.CloseTuesday = model.LotterySchedules.Where(p => p.DayOfTheWeek == 2).FirstOrDefault().CloseHour;//.ToLocalTime();
            vm.CloseWednesday = model.LotterySchedules.Where(p => p.DayOfTheWeek == 3).FirstOrDefault().CloseHour;//.ToLocalTime();
            vm.CloseThursday = model.LotterySchedules.Where(p => p.DayOfTheWeek == 4).FirstOrDefault().CloseHour;//.ToLocalTime();
            vm.CloseFriday = model.LotterySchedules.Where(p => p.DayOfTheWeek == 5).FirstOrDefault().CloseHour;//.ToLocalTime();
            vm.CloseSaturday = model.LotterySchedules.Where(p => p.DayOfTheWeek == 6).FirstOrDefault().CloseHour;//.ToLocalTime();
            vm.CloseSunday = model.LotterySchedules.Where(p => p.DayOfTheWeek == 7).FirstOrDefault().CloseHour;//.ToLocalTime();
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> SaveModelDetail(LotteryViewModel vm)
        {
            var result = await _repository.SaveLotteryDetails(vm);
            if (!result.IsSuccess)
                ModelState.AddModelError("", result.Message);

            return RedirectToAction(nameof(Details), new { id = vm.Id });
        }

        public async Task<IActionResult> Edit(long id)
        {
            var model = await _repository.GetLotery(id);
            if (model == null)
            {
                return NotFound();
            }

            return View("ModelForm", model);
        }

        public IActionResult Create()
        {
            var vm = new Lottery { IsNew = true };
            return View("ModelForm", vm);
        }

        [HttpPost]
        public async Task<IActionResult> SaveModel(long id, Lottery vm)
        {
            if (!ModelState.IsValid)
            {
                return View("ModelForm", vm);
            }

            var result = await _repository.SaveLottery(vm);
            if (!result.IsSuccess)
                ModelState.AddModelError("", result.Message);

            return RedirectToAction(nameof(Details), new { id = vm.Id });
        }

    }
}