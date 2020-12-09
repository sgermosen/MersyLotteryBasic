using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mersy.Common.Models
{
    public class ReportSellerView
    {
        public ICollection<ReportSaleTicketView> ReportSaleTickets { get; set; }
        public ICollection<ReportSaleView> ReportSales { get; set; }

        public ReportSellerView()
        {
            ReportSaleTickets = new Collection<ReportSaleTicketView>();
            ReportSales = new Collection<ReportSaleView>();
        }
    }
}
