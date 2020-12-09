using Mersy.Common.Helpers;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mersy.Common.Entities
{
    public class Payment : AuditEntity, IBaseEntity
    {
        public long Type { get; set; } //1. paid received 2. paid prize
        public long? LotterySaleId { get; set; }
        public LotterySale LotterySale { get; set; }

        [Display(Name = "Fecha")]
        public DateTime? Date { get; set; }

        [Display(Name = "Comentarios")]
        [MaxLength(200, ErrorMessage = "La longitud maxima del campo es {1} caracteres")]
        public string Remarks { get; set; }

        [Display(Name = "Dinero Recibido")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(12,2)")] public decimal? ReceivedAmount { get; set; }

        [Display(Name = "Dinero Devuelto")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(12,2)")]
        public decimal? DevolvedAmount { get; set; }

        [Display(Name = "Monto Pagado")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(12,2)")] public decimal Amountx { get; set; }

        public decimal ComissionAmount { get; set; }

        public decimal SupervisorAmount { get; set; }
    }
}
