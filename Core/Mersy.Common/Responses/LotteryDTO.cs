using System;
using System.Collections.Generic;

namespace Mersy.Common.Responses
{
    public class LotteryResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CloseHour { get; set; }

        public string ColorInHex { get; set; }

        public decimal Loto1First { get; set; }
        public decimal Loto1Second { get; set; }
        public decimal Loto1Third { get; set; }
        public decimal Loto2First { get; set; }
        public decimal Loto2Second { get; set; }
        public decimal Loto3First { get; set; }
        public decimal Loto3Second { get; set; }
        public decimal Loto4First { get; set; }

        public List<LotteryScheduleResponse> Schedules { get; set; }

        public long LotteryFromId { get; set; }
        public LotteryFromResponse LotteryFrom { get; set; }

    }
}
