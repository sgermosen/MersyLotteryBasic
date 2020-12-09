using Mersy.Common.Entities;
using Mersy.Domain.Entities.Cor;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Mersy.Web.Areas.Reports.Models
{
    public class ReportView : Owner
    {
        [Display(Name = "Imagen")]
        public IFormFile ImageFile { get; set; }
        public string PlanName { get; set; }
    

    }
}
