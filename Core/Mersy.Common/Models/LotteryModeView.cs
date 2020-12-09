using System;
namespace Mersy.Common.Models
{
    public class LotteryModeView
    {
        public string Mode { get; set; }
        public decimal Sell { get; set; }
        public decimal  First { get; set; }
        public decimal  Second { get; set; }
        public decimal  Third { get; set; }
        public decimal  Prize { get; set; }
        public int Percent { get; set; }
    
    }
}
