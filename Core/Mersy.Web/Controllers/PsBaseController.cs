using Mersy.Common.Entities;
using Mersy.Infraestructure;
using Mersy.Infraestructure.Extensions;
using Mersy.Web.Helpers;
using Mersy.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mersy.Web.Controllers
{
    public class PsBaseController : Controller
    {
        protected ApplicationDbContext Context;
        protected IUserHelper UserHelper;
        protected IGenericSelectList GenericSelectList;
        public readonly ICurrentUserFactory MyCurrentUser;
        IServiceProvider _serviceProvider;

        public PsBaseController(ApplicationDbContext context,
                                 IUserHelper userHelper, ICurrentUserFactory currentUser)
        {
            Context = context;
            UserHelper = userHelper;
            MyCurrentUser = currentUser;
        }
        public PsBaseController(ApplicationDbContext context,
           IUserHelper userHelper, ICurrentUserFactory currentUser, IGenericSelectList genericSelectList)
        {
            Context = context;
            UserHelper = userHelper;
            GenericSelectList = genericSelectList;
            MyCurrentUser = currentUser;
        }

        public PsBaseController(ApplicationDbContext context,
            IUserHelper userHelper, ICurrentUserFactory currentUser, IServiceProvider serviceProvider, IGenericSelectList genericSelectList)
        {
            Context = context;
            UserHelper = userHelper;
            GenericSelectList = genericSelectList;
            MyCurrentUser = currentUser;
            _serviceProvider = serviceProvider;
        }

        public PsBaseController(ApplicationDbContext context,
            IUserHelper userHelper, ICurrentUserFactory currentUser, IServiceProvider serviceProvider)
        {
            Context = context;
            UserHelper = userHelper;
            MyCurrentUser = currentUser;
            _serviceProvider = serviceProvider;
        }
          
        protected string RenderRazorViewToString(string viewName, object model)
        {
            if (string.IsNullOrEmpty(viewName))
                viewName = ControllerContext.ActionDescriptor.DisplayName;

            ViewData.Model = model;

            using (StringWriter sw = new StringWriter())
            {
                var engine = _serviceProvider.GetService(typeof(ICompositeViewEngine)) as ICompositeViewEngine; // Resolver.GetService(typeof(ICompositeViewEngine)) as ICompositeViewEngine;
                ViewEngineResult viewResult = engine.FindView(ControllerContext, viewName, false);

                ViewContext viewContext = new ViewContext(
                    ControllerContext,
                    viewResult.View,
                    ViewData,
                    TempData,
                    sw,
                    new HtmlHelperOptions() //Added this parameter in
                );

                //Everything is async now!
                var t = viewResult.View.RenderAsync(viewContext);
                t.Wait();

                return sw.GetStringBuilder().ToString();
            }
        }

        protected async Task<Owner> GetOwnerAsync()
        {
            return await Context.Owners.FindAsync(MyCurrentUser.Get.OwnerId);
        }

        protected async Task<ApplicationUser> GetUserAsync()
        {
            return await UserHelper.GetUserByEmailAsync(User.Identity.Name);
        }

        protected async Task<ApplicationUser> GetFullUserAsync()
        {

            return await GetFullUserAsync(User.Identity.Name);
        }

        protected async Task<ApplicationUser> GetFullUserAsync(string email)
        {
            return await Context.Users.Include(s => s.Owner) 
                .Where(p => p.Email == email).FirstOrDefaultAsync();
        }

        protected async Task<ApplicationUser> GetFullUserById(string userId)
        {
            return await Context.Users.Include(s => s.Owner) 
                .Where(p => p.Id == userId).FirstOrDefaultAsync();
        }

        protected async Task<ApplicationUser> GetFullContectedPersonAsync()
        {
            return await GetFullPersonWithEmailAsync(User.Identity.Name);
        }

        protected async Task<ApplicationUser> GetFullPersonWithEmailAsync(string email)
        {
            var user = await Context.Users.Where(p => p.Email == email).FirstOrDefaultAsync();

            return user;
        }

        protected void RulesValidationUsers(PersonView vm, Owner owner)
        {
            //if (string.IsNullOrEmpty((vm.Rnc)) == false)
            //{
            //    var emp = Context.People.Any(p => p.User.Rnc.ToUpper() == vm.Rnc.ToUpper()
            //                                      && p.CreatedUser.Owner == owner);

            //    if (emp)
            //    {
            //        ModelState.AddModelError(string.Empty, "Esta cedula ya esta registrada");
            //        // return View(vm);
            //    }
            //}

            if (string.IsNullOrEmpty((vm.Email)))
            {

                ModelState.AddModelError(string.Empty, "El Email es Obligatorio");

            }

            if (string.IsNullOrEmpty(vm.Email) == false)
            {
                var emp = Context.Users.Any(p => p.Email.ToUpper() == vm.Email.ToUpper()
                                                            && p.Owner == owner);

                if (emp)
                {
                    ModelState.AddModelError(string.Empty, "Este Email ya esta registrado");
                    // return View(vm);
                }
            }
        }

        //public void InitialDateDetermination(ScheduleViewModel vm, out DateTime determinateDateFrom, out DateTime determinateDateTo)
        //{
        //    try
        //    {
        //        determinateDateFrom = ConverToDate(vm.StartDay, vm.StartMonth, vm.StartYear,
        //         vm.StartHours, vm.StartMinutes,
        //         vm.StartHoursMeridian);
        //    }
        //    catch (Exception)
        //    {
        //        determinateDateFrom = DateTime.Now;
        //    }
        //    try
        //    {
        //        determinateDateTo = ConverToDate(vm.EndDay, vm.EndMonth, vm.EndYear,
        //         vm.EndHours, vm.EndMinutes,
        //         vm.EndHoursMeridian);
        //    }
        //    catch (Exception)
        //    {
        //        determinateDateTo = DateTime.Now.AddHours(1);
        //    }
        //}
    }
}