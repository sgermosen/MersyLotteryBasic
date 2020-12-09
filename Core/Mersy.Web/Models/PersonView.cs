using Mersy.Common.Entities;
using Mersy.Domain.Entities.Cor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mersy.Web.Models
{
    public class PersonView : ApplicationUser
    {
        public bool IsNew { get; set; }
        public long PersonId { get; set; }

        public string BornDate { get; set; }

        [Display(Name = "Fecha de Ingreso")]
        //
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }
         

        [MaxLength(15, ErrorMessage = "La longitud maxima del campo es {1} caracteres")]
        [DataType(DataType.PhoneNumber)]
        //    [Index("Person_Cel_Index", IsUnique = true)]
        [Display(Name = "Celular")]
        public string Cel { get; set; }
 

        [Display(Name = "Codigo")]
        public string Record2 { get; set; }

        public string Record3 { get; set; }
          
        public int Record { get; set; }
        public long MaritalSituationId { get; set; }
        public long GenderId { get; set; }
        public long CountryId { get; set; }
        public string Nss { get; set; }
        public string Age { get; set; }


        public IEnumerable<SelectListItem> BloodTypes { get; set; }

        public IEnumerable<SelectListItem> Insurances { get; set; }
        public IEnumerable<SelectListItem> Genders { get; set; }
        public IEnumerable<SelectListItem> MaritalSituations { get; set; }
        public IEnumerable<SelectListItem> Countries { get; set; }

        public long OcupationId { get; set; }
        public IEnumerable<SelectListItem> Ocupations { get; set; }

        public long ReligionId { get; set; }
        public IEnumerable<SelectListItem> Religions { get; set; }

        public long SchoolLevelId { get; set; }
        public IEnumerable<SelectListItem> SchoolLevels { get; set; }
        public IEnumerable<SelectListItem> Specialities { get; set; }

        public IFormFile ImageFile { get; set; }

        public int Day { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public string Companion { get; set; }

        //public ApplicationUser User { get; set; }
    }
}
