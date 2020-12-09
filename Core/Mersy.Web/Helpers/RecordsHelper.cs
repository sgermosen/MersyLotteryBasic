using Mersy.Common.Entities;
using Mersy.Infraestructure;
using System;

namespace Mersy.Web.Helpers
{
    public class RecordsHelper
    {
        private readonly ApplicationDbContext _context;

        public RecordsHelper(ApplicationDbContext context)
        {
            _context = context;
        }
        public int GenerateRecord(Owner owner, int other = 0)
        {
            try
            {
                int maxAge;
                switch (other)
                {
                    //case 1:
                    //    maxAge = _context.Analyticals.Where(u => u.Patient.Person.AuthorId == authorId).Max(p => p.RefNumber);
                    //    break;
                    //case 2:
                    //    maxAge = _context.Customers.Where(u => u.Person.AuthorId == authorId).Max(p => p.Code);
                    //    break;
                    //case 3:
                    //    maxAge = _context.Sales.Where(u => u.User.AuthorId == authorId).Max(p => p.Seq);
                    //    break;
                    //case 4:
                    //    maxAge = _context.Orders.Where(u => u.User.AuthorId == authorId).Max(p => p.Seq);
                    //    break;
                    //case 5:
                    //    maxAge = _context.PaymentDeals.Where(u => u.User.AuthorId == authorId).Max(p => p.Seq);
                    //    break;
                    //case 6:
                    //    maxAge = _context.SaleLiquidations.Where(u => u.User.AuthorId == authorId).Max(p => p.Seq);
                    //    // maxAge = ddd ?? 0;
                    //    break;
                    default:
                        maxAge = 1;
                        break;
                }

                return maxAge + 1;
            }
            catch (Exception)
            {
                return 1;
            }

        }
    }
}
