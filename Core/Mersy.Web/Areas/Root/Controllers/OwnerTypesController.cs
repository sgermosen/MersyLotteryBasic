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
    public class OwnerTypesController : PsBaseController
    {
        private readonly IRoleManager _roleManager;
        private readonly RecordsHelper recordHelper;
        public OwnerTypesController(ApplicationDbContext context, IUserHelper userHelper,
            ICurrentUserFactory currentUser, IRoleManager roleManager, IGenericSelectList genericSelectList) : base(context, userHelper, currentUser, genericSelectList)
        {
            _roleManager = roleManager;
            recordHelper = new RecordsHelper(context);
        }

        public async Task<IActionResult> Index()
        {
            var modelList = await Context.OwnerTypes.Include(p => p.Owners)
                .ToListAsync();

            return View(modelList);
        }

        public async Task<IActionResult> Details(long id)
        {
            var model = await Context.OwnerTypes
                .Include(p => p.Owners)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            var vm = new OwnerType();
            model.Transfer(ref vm, null, false);

            return View(vm);
        }

        public async Task<IActionResult> Edit(long id)
        {
            var model = await Context.OwnerTypes.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            var vm = new OwnerType();
            model.Transfer(ref vm, null, false);

            return View("ModelForm", vm);
        }

        public IActionResult Create()
        {
            var vm = new OwnerType { IsNew = true };

            return View("ModelForm", vm);
        }

        [HttpPost]
        public async Task<IActionResult> SaveModel(long id, OwnerType vm)
        {
            if (!ModelState.IsValid)
            {
                return View("ModelForm", vm);
            }

            var model = new OwnerType();
            vm.Transfer(ref model, null, false);

            if (vm.IsNew)
            {
                Context.Add(model);
            }
            else
            {

                if (id != model.Id)
                {
                    return NotFound();
                }

                var currentModel = await Context.OwnerTypes.FindAsync(model.Id);

                model.Transfer(ref currentModel, null, false);

                Context.Update(currentModel);

            }
            await Context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = model.Id });
        }

        public async Task<IActionResult> Delete(long id)
        {

            var model = await Context.OwnerTypes//.Include(p=>p.Plan).Include(p => p.Owner)
                .FirstOrDefaultAsync(p => p.Id == id);

            Context.Remove(model);

            await Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
