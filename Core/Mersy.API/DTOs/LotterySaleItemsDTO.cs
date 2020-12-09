using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersy.Api.DTOs
{
    public class LotterySaleItemsDTO
    {
        // public long LotterySaleItemId { get; set; }
        public long Id { get; set; }

        public long LotterySaleId { get; set; }
        public LotterySaleDTO LotterySale { get; set; }

        public long LotteryModeId { get; set; } 
        public LotteryModeDTO LotteryMode { get; set; }

        public long LotteryId { get; set; }
        public LotteryDTO Lottery { get; set; }

        public decimal PlayedAmount { get; set; } 
        public string PlayedNumbers { get; set; } 
        public string Played1 { get; set; }
        public string Played2 { get; set; }
        public string Played3 { get; set; }
        public decimal Prize { get; set; }
    }
}
