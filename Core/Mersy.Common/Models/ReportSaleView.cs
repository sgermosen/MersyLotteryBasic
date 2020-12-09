using System;
namespace Mersy.Common.Models
{
    public class ReportSaleView
    {
        public string Seller { get; set; }
        public string Lottery { get; set; }
        public long LotteryId { get; set; }
        public decimal SaleAmounts { get; set; }
        public decimal Results { get; set; }
        public decimal Prizes { get; set; }
        public decimal Comissions { get; set; }
        public decimal SupComissions { get; set; }
        public string Percent { get; set; }
        public string Ticket { get; set; }
        public DateTime Date { get;  set; }
        public LotterySaleView LotterySaleView { get; set; }
    }
}
