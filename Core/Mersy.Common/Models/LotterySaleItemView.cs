using Mersy.Common.Entities;
using System.Collections.Generic;

namespace Mersy.Common.Models
{
    public class LotterySaleItemView : LotterySaleItem
    {
        public decimal Limit { get; set; }
        public decimal Available { get; set; }
        public decimal Cumulative { get; set; }
        public string Number { get; set; }
        public string LotteryModeName { get; set; }
        public string LotteryName { get; set; }
        public List<LotterySale> LotterySales { get; set; }

   
    }
}
