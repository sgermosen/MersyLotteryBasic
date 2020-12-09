using Mersy.Common.Helpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mersy.Common.Entities
{
    public class LotterySale : AuditEntity, IBaseEntity
    {
        public string Ticket { get; set; }

        public string Barcode { get; set; }

        //public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(12,2)")]
        public decimal TotalAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Prize { get; set; }

        public int SeqByOwner { get; set; }

        public int SeqByShop { get; set; }

        //public long CashierDetailId { get; set; }
        //public CashierDetail CashierDetail { get; set; }

        public ICollection<LotterySaleItem> LotterySaleItems { get; set; }

        public string Remarks { get; set; }

        public bool WasPaid { get; set; }

        public bool Anulated { get; set; }
        public bool Winner { get; set; }

        [NotMapped]
        public long PaymentTypeId { get; set; }

        [NotMapped]
        public long ParentId { get; set; }

        public bool AnulatedSol { get; set; }

        public LotterySale()
        {
            LotterySaleItems = new Collection<LotterySaleItem>();
        }

    }
}
