using CommonTasks.Data;
using Mersy.Common.Entities;
using Mersy.Infraestructure;
using Mersy.Infraestructure.Extensions;
using Mersy.Web.Controllers;
using Mersy.Web.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Mersy.Web.Areas.Root.Controllers
{
    [Area("Root")]
    [Authorize(Roles = "Root")]
    public class LotteryModesController : PsBaseController
    {
        private readonly IRoleManager _roleManager;
        private readonly RecordsHelper recordHelper;
        public LotteryModesController(ApplicationDbContext context, IUserHelper userHelper,
            ICurrentUserFactory currentUser, IRoleManager roleManager) : base(context, userHelper, currentUser)
        {
            _roleManager = roleManager;
            recordHelper = new RecordsHelper(context);
        }

        public async Task<IActionResult> Index()
        {
            var modelList = await Context.LotteryModes
                .ToListAsync();

            return View(modelList);
        }

        public async Task<IActionResult> Details(long id)
        {
            var model = await Context.LotteryModes
                .FirstOrDefaultAsync(p => p.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            //var vm = new LotteryMode();
            //model.Transfer(ref vm, null, false);
            LoadLocalSelectList(model);
            return View(model);
        }

        private void LoadLocalSelectList(LotteryMode model)
        {
            //ViewData["Currencies"] = new SelectList(Context.Set<LotteryPrizes>(), "Id", "Name", model.CurrencyId);
            //ViewData["Periodicities"] = new SelectList(Context.Set<Periodicity>(), "Id", "Name", model.PeriodicityId);
        }

        public async Task<IActionResult> Edit(long id)
        {
            var model = await Context.LotteryModes.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            //var vm = new LotteryMode();
            //model.Transfer(ref vm, null, false);

            LoadLocalSelectList(model);
            return View("ModelForm", model);
        }

        public IActionResult Create()
        {
            var vm = new LotteryMode { IsNew = true, PlayableNumber = 1, AwardedNumber = 1 }; LoadLocalSelectList(vm);
            return View("ModelForm", vm);
        }

        [HttpPost]
        public async Task<IActionResult> SaveModel(long id, LotteryMode vm)
        {
            if (vm.AwardedNumber > 3 || vm.AwardedNumber < 1)
                ModelState.AddModelError(string.Empty, "Error en la cantidad de numeros premiables");
            if (vm.PlayableNumber > 8 || vm.PlayableNumber < 1)
                ModelState.AddModelError(string.Empty, "Error en la cantidad de numeros jugables");

            if (!ModelState.IsValid)
            {
                LoadLocalSelectList(vm);
                return View("ModelForm", vm);
            }

            //var model = new LotteryMode();
            //vm.Transfer(ref model, null, false);

            if (vm.IsNew)
            {
                Context.Add(vm);
                await Context.SaveChangesAsync();

                var avails = await Context.Lotteries.ToListAsync();
                //LotteryAvailable avail;
                //foreach (var item in avails)
                //{
                //    avail = new LotteryAvailable { LotteryId = item.Id, LotteryModeId = vm.Id };
                //    Context.Add(avail);
                //}
            }
            else
            {
                if (id != vm.Id)
                {
                    return NotFound();
                }

                var currentModel = await Context.LotteryModes.FindAsync(vm.Id);

                //Only Update the Neccesary fields
                vm.Transfer(ref currentModel, null, false);

                Context.Update(currentModel);

            }

            await Context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = vm.Id });
        }

        public async Task<IActionResult> Delete(long id)
        {
            //var avails = await Context.LotteryAvailables.Where(p => p.LotteryModeId == id).ToListAsync();

            //foreach (var item in avails)
            //{
            //    Context.Remove(item);
            //}

            //var prizes = await Context.LotteryPrizes.Where(p => p.LotteryModeId == id).ToListAsync();

            //foreach (var item in prizes)
            //{
            //    Context.Remove(item);
            //} 

            var model = await Context.LotteryModes.FindAsync(id);
            Context.Remove(model);

            await Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
