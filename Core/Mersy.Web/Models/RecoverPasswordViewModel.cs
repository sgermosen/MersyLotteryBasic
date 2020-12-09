using System.ComponentModel.DataAnnotations;

namespace Mersy.Web.Models
{
    public class RecoverPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }

}
