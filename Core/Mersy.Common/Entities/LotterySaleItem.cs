using Mersy.Common.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mersy.Common.Entities
{
    public class LotterySaleItem : AuditEntity, IBaseEntity
    {
        public long LotterySaleId { get; set; }
        public LotterySale LotterySale { get; set; }

        public long LotteryModeId { get; set; }

        public LotteryMode LotteryMode { get; set; }

        public long LotteryId { get; set; }
        public Lottery Lottery { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal PlayedAmount { get; set; }

        public string PlayedNumbers { get; set; }

        public string Played1 { get; set; }
        public string Played2 { get; set; }
        public string Played3 { get; set; }
        public decimal Prize { get; set; }
        public decimal Prize1 { get; set; }
        public decimal Prize2 { get; set; }
        public decimal Prize3 { get; set; }
    }
}
