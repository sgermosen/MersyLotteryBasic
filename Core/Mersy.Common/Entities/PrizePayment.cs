using Mersy.Common.Helpers;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mersy.Common.Entities
{
    public class PrizePayment : AuditEntity, IBaseEntity
    {
        [Display(Name = "Monto")]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Amount { get; set; }
          
        [Display(Name = "Fecha")]
        public DateTime? Date { get; set; }

        public string SellerId { get; set; }
        public ApplicationUser Seller { get; set; }

        public bool UseSupervisorAmount { get; set; }
        public decimal PreviousSupervisorAmount { get; set; }

        [NotMapped]
        public string DateF { get; set; }

    }
}