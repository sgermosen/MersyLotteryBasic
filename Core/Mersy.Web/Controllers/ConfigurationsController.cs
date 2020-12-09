namespace Mersy.Web.Areas.Administration.Controllers
{
    using CommonTasks.Data;
    using Mersy.Infraestructure;
    using Mersy.Infraestructure.Extensions;
    using Mersy.Web.Areas.Reports.Models;
    using Mersy.Web.Controllers;
    using Mersy.Web.Helpers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

     
    [Authorize(Roles = "Admin,SuperUser,Supervisor,User")]
    public class ConfigurationsController : PsBaseController
    {
        public ConfigurationsController(ApplicationDbContext context, IUserHelper userHelper, ICurrentUserFactory currentUser) : base(context, userHelper, currentUser)
        {
        }

        [Authorize(Roles = "Admin,SuperUser,Supervisor")]
        public async Task<IActionResult> EditOwner()
        {
            var rpt = new ReportView();
            var owner = await GetOwnerAsync();

            var plan = await Context.OwnerPlans.Include(p => p.Plan).FirstOrDefaultAsync(p => p.Owner == owner);
            owner.Transfer(ref rpt);
            string planName = string.Empty;
            if (plan != null)
                planName = plan.Name;

            rpt.PlanName = planName;

            return View(rpt);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,SuperUser,Supervisor")]
        public async Task<IActionResult> EditOwner(ReportView view)
        {
            if (!ModelState.IsValid) return View(view);
            var author = await GetOwnerAsync();
            if (view.ImageFile != null)
            {

                var path = FileHelper.UploadFile(view.ImageFile, view.Imagen, "images", "Logos", ref author);
                author.Imagen = path;
                Context.Update(author);
            }

            //  author.Code = view.Code;

            author.Rnc = view.Rnc;
            author.LastName = view.LastName;
            // author.Email = view.Email;
            //  author.WebAddress = view.WebAddress;
            author.Address = view.Address;
            author.Imagen = view.Imagen;
            author.Tel = view.Tel;
            author.PrefixExp = view.PrefixExp;
            author.PrefixFact = view.PrefixFact;
            author.PrefixNcf = view.PrefixNcf;
            author.SeqNcf = view.SeqNcf;
            author.PrefixFinalFact = view.PrefixFinalFact;
            author.NcfEnds = view.NcfEnds;
            author.SeqFact = view.SeqFact;
            author.Header1 = view.Header1;
            author.Header2 = view.Header2;
            author.Header3 = view.Header3;
            author.Footer1 = view.Footer1;
            author.Footer2 = view.Footer2;
            author.Footer3 = view.Footer3;
            author.UserNameInReport = view.UserNameInReport;




            Context.Entry(author).State = EntityState.Modified;

            await Context.SaveChangesAsync();
            return RedirectToAction("Index", "Options");
        }




    }
}