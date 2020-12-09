using Mersy.Common.Entities;
using System.Collections.Generic;

namespace Mersy.Common.Models
{
    public class LotterySaleView : LotterySale
    {
        public string SellShop { get; set; }
        public string SellUser { get; set; }
        public bool Won { get; set; }
        public List<LotterySale> Sales { get; set; }
        public List<LotteryView> Lotteries { get; set; }
        public decimal SalesAmount { get; set; }
        public decimal PrizeAmount { get; set; }
        public decimal ComissionAmount { get; set; }
        public decimal BalanceAmount { get; set; }
        public LotterySale Sale { get;  set; }
        public List<LotteryModeView> Modes { get; set; }
    }
}
