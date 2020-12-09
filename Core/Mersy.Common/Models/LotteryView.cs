using Mersy.Common.Entities;

namespace Mersy.Common.Models
{
    public class LotteryView : Lottery
    {
        public long ModeId { get; set; }
        public decimal SalesAmount { get; set; }
        public decimal Prizes { get; set; }
        public decimal Comissions { get; set; }
        public decimal Results { get; set; }
        public decimal Percent { get; set; }
    }
}