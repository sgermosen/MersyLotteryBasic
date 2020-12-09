using System.ComponentModel.DataAnnotations;

namespace Mersy.Common.Request
{
    public class UserRequest
    {
        [Required]
        public string Document { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }

        public string PasswordConfirm { get; set; }

        [Required]
        public int CityId { get; set; }

        public byte[] ImageArray { get; set; }

        public double Latitude { get; set; }

        public double Logitude { get; set; }
    }
}
