using System;

namespace Mersy.Common.Responses
{
    public class LotteryScheduleResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public long LotteryId { get; set; }
        public LotteryResponse Lottery { get; set; }

        public int DayOfTheWeek { get; set; }

        public DateTime CloseHour { get; set; }

        public DateTime InactiveDate { get; set; }
    }
}
