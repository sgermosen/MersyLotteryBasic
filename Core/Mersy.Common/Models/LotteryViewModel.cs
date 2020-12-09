using Mersy.Common.Entities;
using System;

namespace Mersy.Common.Models
{
    public class LotteryViewModel : Lottery
    {
        public DateTime CloseMonday { get; set; }
        public DateTime CloseTuesday { get; set; }
        public DateTime CloseWednesday { get; set; }
        public DateTime CloseThursday { get; set; }
        public DateTime CloseFriday { get; set; }
        public DateTime CloseSaturday { get; set; }
        public DateTime CloseSunday { get; set; }

       
    }
}
