using Mersy.Infraestructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersy.Api.Helpers
{
    public class TicketExistsAttribute : Attribute, IAsyncResourceFilter
    {
        private readonly ApplicationDbContext Dbcontext;

        public TicketExistsAttribute(ApplicationDbContext context)
        {
            this.Dbcontext = context;
        }

        public async Task OnResourceExecutionAsync(ResourceExecutingContext context, 
            ResourceExecutionDelegate next)
        {
            var lotterySaleIdObject = context.HttpContext.Request.RouteValues["lotterySaleId"];

            if (lotterySaleIdObject == null)
            {
                return;
            }

            var lotterySaleId = int.Parse(lotterySaleIdObject.ToString());

            var existeLotterySale = await Dbcontext.LotterySales.AnyAsync(x => x.Id == lotterySaleId);

            if (!existeLotterySale)
            {
                context.Result = new NotFoundResult();
            }
            else
            {
                await next();
            }
        }
    }
}
