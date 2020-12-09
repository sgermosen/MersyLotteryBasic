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
    public class PlanTransactionsController : PsBaseController
    {
        private readonly IRoleManager _roleManager;
        private readonly RecordsHelper recordHelper;
        public PlanTransactionsController(ApplicationDbContext context, IUserHelper userHelper,
            ICurrentUserFactory currentUser, IRoleManager roleManager) : base(context, userHelper, currentUser)
        {
            _roleManager = roleManager;
            recordHelper = new RecordsHelper(context);
        }

        public async Task<IActionResult> Index()
        {
            var modelList = await Context.PlanTransactions
                .Include(p => p.Currency)
               .Include(p => p.OwnerPlan).ThenInclude(p => p.Owner)
                .Include(p => p.OwnerPlan).ThenInclude(p => p.Plan)
                .Include(p => p.PaymentType)
                .ToListAsync();

            return View(modelList);
        }

        public async Task<IActionResult> Details(long id)
        {
            var model = await Context.PlanTransactions
                 .Include(p => p.Currency)
                .Include(p => p.OwnerPlan).ThenInclude(p => p.Owner)
                .Include(p => p.OwnerPlan).ThenInclude(p => p.Plan)
                .Include(p => p.PaymentType)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            //var vm = new PlanTransaction();
            //model.Transfer(ref vm, null, false);
            LoadLocalSelectList(model);
            return View(model);
        }

        private void LoadLocalSelectList(PlanTransaction model)
        {
            ViewData["Currencies"] = new SelectList(Context.Set<Currency>(), "Id", "Name", model.CurrencyId);
            ViewData["OwnerPlans"] = new SelectList(Context.Set<OwnerPlan>(), "Id", "Name", model.OwnerPlanId);
            ViewData["PaymentTypes"] = new SelectList(Context.Set<PaymentType>(), "Id", "Name", model.PaymentTypeId);
        }

        public async Task<IActionResult> Edit(long id)
        {
            var model = await Context.PlanTransactions.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            //var vm = new PlanTransaction();
            //model.Transfer(ref vm, null, false);

            LoadLocalSelectList(model);
            return View("ModelForm", model);
        }

        public IActionResult Create()
        {


            var vm = new PlanTransaction { IsNew = true };
            LoadLocalSelectList(vm);
            return View("ModelForm", vm);
        }

        [HttpPost]
        public async Task<IActionResult> SaveModel(long id, PlanTransaction vm)
        {
            if (!ModelState.IsValid)
            {
                LoadLocalSelectList(vm);
                return View("ModelForm", vm);
            }

            //var model = new PlanTransaction();
            //vm.Transfer(ref model, null, false);

            if (vm.IsNew)
            {
                Context.Add(vm);
            }
            else
            {
                if (id != vm.Id)
                {
                    return NotFound();
                }

                var currentModel = await Context.PlanTransactions.FindAsync(vm.Id);

                //Only Update the Neccesary fields
                vm.Transfer(ref currentModel, null, false);

                Context.Update(currentModel);

            }

            await Context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = vm.Id });
        }

        public async Task<IActionResult> Delete(long id)
        {
            var model = await Context.PlanTransactions.FindAsync(id);
            Context.Remove(model);
            await Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
