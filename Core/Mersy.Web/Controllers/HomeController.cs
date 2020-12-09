namespace Mersy.Web.Controllers
{
    using Mersy.Infraestructure;
    using Mersy.Infraestructure.Extensions;
    using Mersy.Repositories.Implementations.Cor;
    using Mersy.Web.Helpers;
    using Mersy.Web.Models;
    using Mersy.Common.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.SignalR;
    using Mersy.Web.Hubs;
    using CommonTasks.Data;
    using Mersy.Common.Helpers;

    public class HomeController : PsBaseController
    {
        // private readonly ApplicationDbContext _context;

        //private readonly MersyclasicDbContext _contextFromClasic;
        private readonly IConfiguration _configuration;
        private readonly LotterySaleRepository _repository;
        private readonly RecordsHelper recordHelper;

        private readonly IHubContext<NotificationHub> _notificationHubContext;

        public HomeController(ApplicationDbContext context, IUserHelper userHelper, ICurrentUserFactory currentUser,
            IConfiguration configuration, LotterySaleRepository repository,
            IHubContext<NotificationHub> notificationHubContext) : base(context, userHelper, currentUser)
        {
            //   _context = context;
            //  _contextFromClasic = contextFromClasic;
            _configuration = configuration;
            _repository = repository;
            recordHelper = new RecordsHelper(context);
            _notificationHubContext = notificationHubContext;
        }


        [HttpPost]
        public async Task<IActionResult> Getnotifications()
        {
            var models = new List<Notification>();
            var anulationsRequest =   _repository.GetAnulatedSol(MyCurrentUser.Get.OwnerId);

            if (anulationsRequest.Count() > 0)
            {
                models.Add(new Notification
                {
                    Action = "ToAnulated",
                    Controller = "Lotteries",
                    SeeIt = false,
                    Area = "",
                    Message = "Hay Solicitudes Pendientes",
                    Title = "Solicitud de Anulacion",
                    Icon = "icon-bell",
                    ElementId = 1
                });
            }


            return PartialView("_NotificationPartial", models);
        }

        //[Authorize(Roles = "User,Admin")]
        public async Task<IActionResult> Index(string msg = "")
        {
            if (this.User.Identity.IsAuthenticated)
            {
                var date = DateTime.Now;
                var user = await GetFullUserAsync();

                var vm = await _repository.GetSalesForHomeResume(date, date, MyCurrentUser.Get.OwnerId, user, true);
                var newvm = new Article();
                vm.Transfer(ref newvm, null, false);

                var models = new List<Notification>();
                models.Add(new Notification
                {
                    Action = "Index",
                    Controller = "Home",
                    SeeIt = false,
                    Area = "",
                    Message = "Go to Home",
                    Title = "HomeV",
                    Icon = "icon-bell",
                    ElementId = 1
                });
                models.Add(new Notification
                {
                    Action = "Index",
                    Controller = "Home",
                    SeeIt = false,
                    Area = "",
                    Message = "Go to Home",
                    Title = "Homey",
                    Icon = "icon-bell",
                    ElementId = 1
                });
                models.Add(new Notification
                {
                    Action = "Index",
                    Controller = "Home",
                    SeeIt = false,
                    Area = "",
                    Message = "Go to Home",
                    Title = "Homex",
                    Icon = "icon-bell",
                    ElementId = 1
                });
                models.Add(new Notification
                {
                    Action = "Index",
                    Controller = "Home",
                    SeeIt = false,
                    Area = "",
                    Message = "Go to Home",
                    Title = "HomeV",
                    Icon = "icon-bell",
                    ElementId = 1
                });
                await _notificationHubContext.Clients.All.SendAsync("sendToUser", "hi,", "xx");

                return View(newvm);
            }
            var isRunningOn = _configuration["IsRunningOn"];

            if (isRunningOn == "Azure")
            {
                return this.RedirectToAction("Login", "Account");
                //return RedirectToAction("IndexWeb");
            }
            ViewBag.Msg = msg;
            return this.RedirectToAction("Login", "Account");

        }


        public IActionResult Lock()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ErrorPage(string message)
        {
            ViewBag.Message = message;

            return View();
        }

        [Route("error/404")]
        public IActionResult Error404()
        {
            return View();
        }
    }
}
