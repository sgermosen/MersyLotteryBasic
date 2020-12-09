namespace Mersy.Web.Areas.Administration.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
     
    [Authorize(Roles = "Admin,SuperUser,Supervisor,User")]
    public class OptionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}