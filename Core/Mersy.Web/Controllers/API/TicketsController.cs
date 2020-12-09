using Mersy.Common.Entities;
using Mersy.Common.Models;
using Mersy.Common.Responses;
using Mersy.Infraestructure;
using Mersy.Web.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Mersy.Web.Controllers.API
{ 
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserHelper _userHelper;

        public TicketsController(ApplicationDbContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        [HttpPost]
        public async Task<IActionResult> PostTicket ([FromBody] TicketResponse request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            string email = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                return NotFound("Error001");
            }

            //LotterySale order = new LotterySale
            //{
            //    Date = DateTime.UtcNow,
            //    OrderDetails = new List<OrderDetail>(),
            //    OrderStatus = OrderStatus.Pending,
            //    PaymentMethod = request.PaymentMethod,
            //    Remarks = request.Remarks,
            //    User = user
            //};

            //foreach (OrderDetailResponse item in request.OrderDetails)
            //{
            //    Product product = await _context.Products.FindAsync(item.Product.Id);
            //    if (product == null)
            //    {
            //        return NotFound("Error002");
            //    }

            //    order.OrderDetails.Add(new OrderDetail
            //    {
            //        Price = product.Price,
            //        Product = product,
            //        Quantity = item.Quantity,
            //        Remarks = item.Remarks
            //    });
            //}

            //_context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return Ok();// order);
        }

        [HttpGet]
        public async Task<IActionResult> GetTickets()
        {
            string email = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                return NotFound("Error001");
            }

            var tickets = await _context.LotterySales.ToListAsync();
            return Ok(tickets);
        }

        [HttpPut]
        public async Task<IActionResult> PutTickets([FromBody] LotterySale order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string email = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                return NotFound("Error001");
            }

            //Order currentOrder = await _context.Orders
            //    .Include(o => o.User)
            //    .ThenInclude(u => u.City)
            //    .Include(o => o.OrderDetails)
            //    .ThenInclude(od => od.Product)
            //    .ThenInclude(od => od.Category)
            //    .Include(o => o.OrderDetails)
            //    .ThenInclude(od => od.Product)
            //    .ThenInclude(od => od.ProductImages)
            //    .FirstOrDefaultAsync(o => o.Id == order.Id && o.User.Id == user.Id);
            //if (currentOrder == null)
            //{
            //    return NotFound();
            //}

            //currentOrder.OrderStatus = order.OrderStatus;
            //currentOrder.Remarks = order.Remarks;
            //_context.Orders.Update(currentOrder);
            await _context.SaveChangesAsync();
            return Ok();// (currentOrder);
        }
    }

}

