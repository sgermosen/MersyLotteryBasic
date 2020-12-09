using Mersy.Common.Entities;

namespace Mersy.Common.Models
{
    public class LotteryTicketView : LotterySale
    {
        public string Imagen { get; set; }
        public string ImageFullPath { get; set; }
        public string Header1 { get; set; }
        public string Header2 { get; set; }
        public string Header3 { get; set; }
        public string Footer1 { get; set; }
        public string Footer2 { get; set; }
        public string Footer3 { get; set; }
        public string UserName { get; set; }

    }
}
