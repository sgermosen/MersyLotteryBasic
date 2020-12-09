using Mersy.Common.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Mersy.Common.Entities
{
    public class PaymentType : BaseEntity
    {
        [Required(ErrorMessage = "El Campo es requerido")]
        [MaxLength(10, ErrorMessage = "La longitud maxima del campo es {1} caracteres")]
        // [Index("PaymentType_Code_Index", IsUnique = true)]
        [Display(Name = "Codigo")]
        public string Code { get; set; }

    }
}
