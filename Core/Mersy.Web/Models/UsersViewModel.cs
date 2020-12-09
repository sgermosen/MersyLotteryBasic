using Mersy.Common.Entities;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Mersy.Web.Models
{
    public class UsersViewModel : ApplicationUser
    {
        public long CashierId { get; set; }
        public ICollection<string> Roles { get; set; }
        public IFormFile ImageFile { get;  set; }
        public bool IsNew { get;  set; }
        public int TypeId { get; set; }
        public string ActualPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
