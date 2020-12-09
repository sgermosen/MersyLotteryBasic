using Mersy.Common.Entities;
using System.Collections.Generic;

namespace Mersy.Web.Areas.Administration.Models
{
    public class SellLotteryView
    {
        public LotterySale LotterySale { get; set; }

        public List<LotterySaleItem> Items { get; set; }
    }
}
