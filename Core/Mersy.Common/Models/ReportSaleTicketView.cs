namespace Mersy.Common.Models
{
    public class ReportSaleTicketView
    {
        public int Makeit { get; set; }
        public int Winners { get; set; }
        public int Paids { get; set; }
        public int Deleted { get; set; }
        public int Pending { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal PendingAmount { get; set; }
    }
}
