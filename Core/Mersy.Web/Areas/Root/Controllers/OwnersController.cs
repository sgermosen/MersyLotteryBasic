using CommonTasks.Data;
using Mersy.Common.Entities;
using Mersy.Infraestructure;
using Mersy.Infraestructure.Extensions;
using Mersy.Web.Controllers;
using Mersy.Web.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Mersy.Web.Areas.Root.Controllers
{
    [Area("Root")]
    [Authorize(Roles = "Root")]
    public class OwnersController : PsBaseController
    {
        private readonly IRoleManager _roleManager;
        private readonly RecordsHelper recordHelper;
        private readonly IUserHelper _userHelper;
        public OwnersController(ApplicationDbContext context, IUserHelper userHelper,
            ICurrentUserFactory currentUser, IRoleManager roleManager) : base(context, userHelper, currentUser)
        {
            _roleManager = roleManager;
            _userHelper = userHelper;
            recordHelper = new RecordsHelper(context);
        }

        public async Task<IActionResult> Index()
        {
            var modelList = await Context.Owners
                .Include(p => p.OwnerPlans)
                .ToListAsync();

            return View(modelList);
        }

        public async Task<IActionResult> Details(long id)
        {
            var model = await Context.Owners
                .Include(p => p.OwnerPlans)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            //var vm = new Owner();
            //model.Transfer(ref vm, null, false);
            LoadLocalSelectList(model);
            return View(model);
        }

        private void LoadLocalSelectList(Owner model)
        {
            ViewData["OwnerTypes"] = new SelectList(Context.Set<OwnerType>(), "Id", "Name", model.OwnerTypeId);

        }

        public async Task<IActionResult> Edit(long id)
        {
            var model = await Context.Owners.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            //var vm = new Owner();
            //model.Transfer(ref vm, null, false);
            LoadLocalSelectList(model);
            return View("ModelForm", model);
        }

        public IActionResult Create()
        {


            var vm = new Owner { IsNew = true };
            LoadLocalSelectList(vm);
            return View("ModelForm", vm);
        }

        [HttpPost]
        public async Task<IActionResult> SaveModel(long id, Owner vm)
        {
            if (!ModelState.IsValid)
            {
                LoadLocalSelectList(vm);
                return View("ModelForm", vm);
            }

            //var model = new Owner();
            //vm.Transfer(ref model, null, false);

            if (vm.IsNew)
            {
                //if (string.IsNullOrEmpty((vm.Rnc)) == false)
                //{
                //    var existingRnc = Context.People.Any(p => p.User.Rnc.ToUpper() == vm.Rnc.ToUpper());

                //    if (existingRnc)
                //    {
                //        ModelState.AddModelError(string.Empty, "Esta cedula ya esta registrada");
                //        return View("ModelForm", vm);
                //    }
                //}

                if (string.IsNullOrEmpty((vm.Email)))
                {

                    ModelState.AddModelError(string.Empty, "El Email es Obligatorio");
                    return View("ModelForm", vm);

                }

                if (string.IsNullOrEmpty(vm.Email) == false)
                {
                    var existingEmail = Context.Users.Any(p => p.Email.ToUpper() == vm.Email.ToUpper());

                    if (existingEmail)
                    {
                        ModelState.AddModelError(string.Empty, "Este Email ya esta registrado");
                        return View("ModelForm", vm);
                    }
                }

                vm.StartDate = DateTime.Now;
                await Context.Owners.AddAsync(vm);

                var user = ApplicationUser.Create(vm,
                    vm.Name, vm.Address, vm.Tel,
                       vm.Email, vm.Name, true, true, true, true);

                var result = await _userHelper.AddUserAsync(user, "824455");
                if (result != IdentityResult.Success)
                {
                    ModelState.AddModelError(string.Empty, "Usuario no pudo ser creado");
                    return View("ModelForm", vm);
                }

                // await Context.SaveChangesAsync();
                await _userHelper.AddClaim(user, new Claim("OwnerId", vm.Id.ToString()));

                await _userHelper.AddUserToRoleAsync(user, "Admin");
                await _userHelper.AddUserToRoleAsync(user, "User");
                //await _userHelper.AddUserToRoleAsync(user, "Doctor");
                //await _userHelper.AddUserToRoleAsync(user, "Employee");
                //await _userHelper.AddUserToRoleAsync(user, "Teacher");

                var path = string.Empty;

                // path = await FileHelper.UploadFile(vm.ImageFile, path, rootFolder, folder);

                vm.Imagen = path;
                var record = recordHelper.GenerateRecord(vm);
                 
                await Context.SaveChangesAsync();

            }
            else
            {
                if (id != vm.Id)
                {
                    return NotFound();
                }

                var currentModel = await Context.Owners.FindAsync(vm.Id);

                //Only Update the Neccesary fields
                vm.Transfer(ref currentModel, null, false);

                Context.Update(currentModel);

            }

            await Context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = vm.Id });
        }

        public async Task<IActionResult> Delete(long id)
        {
            var model = await Context.Owners.FindAsync(id);
            Context.Remove(model);
            await Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
