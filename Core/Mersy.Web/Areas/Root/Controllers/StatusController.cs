using CommonTasks.Data;
using Mersy.Domain.Entities.Cor;
using Mersy.Infraestructure;
using Mersy.Infraestructure.Extensions;
using Mersy.Repositories.Contracts.Cor;
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
    public class StatusController : PsBaseController
    {
        private readonly IRoleManager _roleManager;
        private readonly RecordsHelper recordHelper;
        public StatusController(ApplicationDbContext context, IUserHelper userHelper,
            ICurrentUserFactory currentUser, IRoleManager roleManager) : base(context, userHelper, currentUser)
        {
            _roleManager = roleManager;
            recordHelper = new RecordsHelper(context);
        }

        public async Task<IActionResult> Index()
        {
            var modelList = await Context.Status
                .ToListAsync();

            return View(modelList);
        }

        public async Task<IActionResult> Details(long id)
        {
            var model = await Context.Status
                .FirstOrDefaultAsync(p => p.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            //var vm = new Status();
            //model.Transfer(ref vm, null, false);
            return View(model);
        }

        public async Task<IActionResult> Edit(long id)
        {
            var model = await Context.Status.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            //var vm = new Status();
            //model.Transfer(ref vm, null, false);

            return View("ModelForm", model);
        }

        public IActionResult Create()
        {

            var vm = new Status { IsNew = true };
            return View("ModelForm", vm);
        }

        [HttpPost]
        public async Task<IActionResult> SaveModel(long id, Status vm)
        {
            if (!ModelState.IsValid)
            {
                return View("ModelForm", vm);
            }

            //var model = new Status();
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

                var currentModel = await Context.Status.FindAsync(vm.Id);

                //Only Update the Neccesary fields
                vm.Transfer(ref currentModel, null, false);

                Context.Update(currentModel);

            }

            await Context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = vm.Id });
        }

        public async Task<IActionResult> Delete(long id)
        {
            var model = await Context.Status.FindAsync(id);
            Context.Remove(model);
            await Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
