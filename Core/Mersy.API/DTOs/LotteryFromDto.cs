using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersy.Api.DTOs
{
    public class LotteryFromDTO
    {
        public long LotteryFromId { get; set; }
        public string Name { get; set; }

        public List<LotteryDTO> Lotteries { get; set; }

    }
}
