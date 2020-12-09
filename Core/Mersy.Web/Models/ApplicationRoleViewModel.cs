using System.ComponentModel.DataAnnotations;

namespace Mersy.Web.Models
{
    public class ApplicationRoleViewModel
    {
        public string RoleId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}
