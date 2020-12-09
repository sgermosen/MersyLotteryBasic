using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersy.Api.DTOs
{
    public class LotteryDTO
    {
        public long LotteryId { get; set; }
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
 
        public List<LotteryScheduleDTO> LotterySchedules { get; set; }

        public long LotteryFromId { get; set; } 
        public LotteryFromDTO LotteryFrom { get; set; }

    }
}
