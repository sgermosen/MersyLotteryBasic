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
using System;
using System.Threading.Tasks;

namespace Mersy.Web.Areas.Root.Controllers
{
    [Area("Root")]
    [Authorize(Roles = "Root")]
    public class OwnerPlansController : PsBaseController
    {
        private readonly IRoleManager _roleManager;
        private readonly RecordsHelper recordHelper;
        public OwnerPlansController(ApplicationDbContext context, IUserHelper userHelper,
            ICurrentUserFactory currentUser, IRoleManager roleManager) : base(context, userHelper, currentUser)
        {
            _roleManager = roleManager;
            recordHelper = new RecordsHelper(context);
        }

        public async Task<IActionResult> Index()
        {
            var modelList = await Context.OwnerPlans
                .Include(p => p.Owner)
                .Include(p => p.Plan)
                .ToListAsync();

            return View(modelList);
        }

        public async Task<IActionResult> Details(long id)
        {
            var model = await Context.OwnerPlans
                .Include(p => p.Owner)
                .Include(p => p.Plan)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            //var vm = new OwnerPlan();
            //model.Transfer(ref vm, null, false);
            LoadLocalSelectList(model);
            return View(model);
        }

        private void LoadLocalSelectList(OwnerPlan model)
        {
            ViewData["Plans"] = new SelectList(Context.Set<Plan>(), "Id", "Name", model.PlanId);
            ViewData["Owners"] = new SelectList(Context.Set<Owner>(), "Id", "Name", model.OwnerId);
        }

        public async Task<IActionResult> Edit(long id)
        {
            var model = await Context.OwnerPlans.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            //var vm = new OwnerPlan();
            //model.Transfer(ref vm, null, false);

            LoadLocalSelectList(model);
            return View("ModelForm", model);
        }

        public IActionResult Create()
        {
            var vm = new OwnerPlan { IsNew = true };
            LoadLocalSelectList(vm);
            return View("ModelForm", vm);
        }

        [HttpPost]
        public async Task<IActionResult> SaveModel(long id, OwnerPlan vm)
        {
            if (!ModelState.IsValid)
            {
                LoadLocalSelectList(vm);
                return View("ModelForm", vm);
            }

            //var model = new OwnerPlan();
            //vm.Transfer(ref model, null, false);

            var plan = await Context.Plans.FindAsync(vm.PlanId);
            var owner = await Context.Owners.FindAsync(vm.OwnerId);

            if (vm.IsNew)
            {
                var planTransaction = new PlanTransaction
                {
                    Amount = plan.Amount,
                    CurrencyId = plan.CurrencyId,
                    Date = DateTime.Now,
                    Megabytes = plan.Megabytes,
                    PaymentTypeId = 1,
                    Registers = plan.RegiterCount,
                    UserPosibility = plan.UserPosibility
                };

                owner.MegabytesAvailable += plan.Megabytes;
                owner.RegitersAvailable += plan.RegiterCount;
                owner.UsersAvailable += plan.UserPosibility;

                vm.PlanTransactions.Add(planTransaction);
                Context.Add(vm);

            }
            else
            {

                if (id != vm.Id)
                {
                    return NotFound();
                }

                var currentModel = await Context.OwnerPlans.FindAsync(vm.Id);

                if (vm.OwnerId != currentModel.OwnerId)
                {
                    ModelState.AddModelError(string.Empty, "No Puede Cambiar de Cliente para la Edicion");
                    return View("ModelForm", vm);
                }

                if (currentModel.PlanId != vm.PlanId)
                {
                    var previousPlan = await Context.Plans.FindAsync(currentModel.PlanId);

                    owner.MegabytesAvailable -= previousPlan.Megabytes;
                    owner.RegitersAvailable -= previousPlan.RegiterCount;
                    owner.UsersAvailable -= previousPlan.UserPosibility;

                    owner.MegabytesAvailable += plan.Megabytes;
                    owner.RegitersAvailable += plan.RegiterCount;
                    owner.UsersAvailable += plan.UserPosibility;
                }

                //Only Update the Neccesary fields
                vm.Transfer(ref currentModel, null, false);

                Context.Update(currentModel);

            }
            Context.Update(owner);
            await Context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = vm.Id });
        }

        public async Task<IActionResult> Delete(long id)
        {


            var model = await Context.OwnerPlans//.Include(p=>p.Plan).Include(p => p.Owner)
                .FirstOrDefaultAsync(p => p.Id == id);
            var plan = await Context.Plans.FindAsync(model.PlanId);
            var owner = await Context.Owners.FindAsync(model.OwnerId);

            owner.MegabytesAvailable -= plan.Megabytes;
            owner.RegitersAvailable -= plan.RegiterCount;
            owner.UsersAvailable -= plan.UserPosibility;

            Context.Remove(model);
            Context.Update(owner);

            await Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
