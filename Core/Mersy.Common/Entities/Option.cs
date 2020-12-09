using Mersy.Common.Helpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Mersy.Common.Entities
{
    public class Option : BaseEntity
    {
        [Required(ErrorMessage = "El campo es requerido")]
        [MaxLength(100, ErrorMessage = "La maxima longitud para el campo es {1}")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }


        [MaxLength(100, ErrorMessage = "La maxima longitud para el campo es {1}")]
        public string Link { get; set; }

        [MaxLength(25, ErrorMessage = "La maxima longitud para el campo es {1}")]
        public string Area { get; set; }

        [MaxLength(25, ErrorMessage = "La maxima longitud para el campo es {1}")]
        [Display(Name = "Controlador")]
        public string Controller { get; set; }

        [MaxLength(25, ErrorMessage = "La maxima longitud para el campo es {1}")]
        [Display(Name = "Accion")]
        public string Action { get; set; }

        [Display(Name = "Orden")]
        public int Order { get; set; }

        [MaxLength(100, ErrorMessage = "La maxima longitud para el campo es {1}")]
        [Display(Name = "Class")]
        public string Class { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        public string Icon { get; set; }

        public long OptionModuleId { get; set; }
        public OptionModule OptionModule { get; set; }

        public ICollection<PlanOption> PlanOptions { get; set; }

        public Option()
        {
            PlanOptions = new Collection<PlanOption>();
        }
    }
}
