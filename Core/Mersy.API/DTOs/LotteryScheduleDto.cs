using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersy.Api.DTOs
{
    public class LotteryScheduleDTO  
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public long LotteryId { get; set; }
        public LotteryDTO Lottery { get; set; }

        public int DayOfTheWeek { get; set; }

        public DateTime CloseHour { get; set; }

        public DateTime InactiveDate { get; set; }
    }
}
