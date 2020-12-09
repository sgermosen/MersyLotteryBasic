using Mersy.Common.Helpers;
using System;

namespace Mersy.Common.Entities
{
    public class LotterySchedule : AuditEntity, IBaseEntity
    {
        public long LotteryId { get; set; }
        public Lottery Lottery { get; set; }

        public int DayOfTheWeek { get; set; }

        //  public DateTime OpenHour { get; set; }
        public DateTime CloseHour { get; set; }

        public DateTime InactiveDate { get; set; }

    }
}
