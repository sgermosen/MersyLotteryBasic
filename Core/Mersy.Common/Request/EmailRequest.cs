using System.ComponentModel.DataAnnotations;

namespace Mersy.Common.Request
{
    public class EmailRequest
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
