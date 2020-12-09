using CommonTasks.Data;
using Mersy.Common.Entities;
using Mersy.Infraestructure;
using Mersy.Infraestructure.Extensions;
using Mersy.Web.Controllers;
using Mersy.Web.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Mersy.Web.Areas.Root.Controllers
{
    [Area("Root")]
    [Authorize(Roles = "Root")]
    public class PlansController : PsBaseController
    {
        private readonly IRoleManager _roleManager;
        private readonly RecordsHelper recordHelper;
        public PlansController(ApplicationDbContext context, IUserHelper userHelper,
            ICurrentUserFactory currentUser, IRoleManager roleManager) : base(context, userHelper, currentUser)
        {
            _roleManager = roleManager;
            recordHelper = new RecordsHelper(context);
        }

        public async Task<IActionResult> Index()
        {
            var modelList = await Context.Plans
                .Include(p => p.Currency)
                .Include(p => p.Periodicity)
                .ToListAsync();

            return View(modelList);
        }

        public async Task<IActionResult> Details(long id)
        {
            var model = await Context.Plans
                .Include(p => p.Currency)
                .Include(p => p.Periodicity)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            //var vm = new Plan();
            //model.Transfer(ref vm, null, false);
            LoadLocalSelectList(model);
            return View(model);
        }

        private void LoadLocalSelectList(Plan model)
        {
            ViewData["Currencies"] = new SelectList(Context.Set<Currency>(), "Id", "Name", model.CurrencyId);
            ViewData["Periodicities"] = new SelectList(Context.Set<Periodicity>(), "Id", "Name", model.PeriodicityId);
        }

        public async Task<IActionResult> Edit(long id)
        {
            var model = await Context.Plans.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            //var vm = new Plan();
            //model.Transfer(ref vm, null, false);

            LoadLocalSelectList(model);
            return View("ModelForm", model);
        }

        public IActionResult Create()
        {


            var vm = new Plan { IsNew = true }; LoadLocalSelectList(vm);
            return View("ModelForm", vm);
        }

        [HttpPost]
        public async Task<IActionResult> SaveModel(long id, Plan vm)
        {
            if (!ModelState.IsValid)
            {
                LoadLocalSelectList(vm);
                return View("ModelForm", vm);
            }

            //var model = new Plan();
            //vm.Transfer(ref model, null, false);

            if (vm.IsNew)
            {
                vm.CurrencyId = 1;
                Context.Add(vm);
            }
            else
            {
                if (id != vm.Id)
                {
                    return NotFound();
                }

                var currentModel = await Context.Plans.FindAsync(vm.Id);

                //Only Update the Neccesary fields
                vm.Transfer(ref currentModel, null, false);

                Context.Update(currentModel);

            }

            await Context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = vm.Id });
        }

        public async Task<IActionResult> Delete(long id)
        {
            var model = await Context.Plans.FindAsync(id);
            Context.Remove(model);
            await Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
