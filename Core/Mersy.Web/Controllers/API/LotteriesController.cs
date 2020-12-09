using System;
using System.Threading.Tasks;
using Mersy.Common.Entities;
using Mersy.Common.Responses;
using Mersy.Infraestructure;
using Microsoft.AspNetCore.Mvc;

namespace Mersy.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class LotteriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public LotteriesController(ApplicationDbContext   context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetLotteries()
        {
            return Ok(_context.Lotteries);
        }

        //[HttpPost]
        //public async Task<IActionResult> SaveCuadre([FromBody] Cuadre model)
        //{
        //    bool status = false;
        //    long idi = 0;
        //    var msg = string.Empty;
        //    var openUrl = "";

        //    if (!ModelState.IsValid) return new JsonResult(new { status, idi, msg = "Modelo Invalido" });

        //    var response = new Response();// await _repository.SaveCuadre(model, MyCurrentUser.Get.OwnerId);
        //    if (!response.IsSuccess)
        //        return new JsonResult(new { status, idi, msg = response.Message });

        //    try
        //    {
        //        status = true;
        //        idi = model.Id;

        //        openUrl = Url.Action("PrintTicket", new { id = idi });
        //    }
        //    catch (Exception ex)
        //    {
        //        msg = ex.Message;
        //        status = false;
        //    }
        //    return new JsonResult(new { status, idi, msg, openUrl });
        //}



    }
}
