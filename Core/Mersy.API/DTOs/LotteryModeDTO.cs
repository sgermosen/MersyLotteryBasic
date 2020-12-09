using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersy.Api.DTOs
{
    public class LotteryModeDTO
    {
        public long LotteryModeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int PlayableNumber { get; set; }

        public int AwardedNumber { get; set; }
    }
}
