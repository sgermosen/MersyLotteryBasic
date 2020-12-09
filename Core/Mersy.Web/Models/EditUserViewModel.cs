using Microsoft.AspNetCore.Http;
using System;

namespace Mersy.Web.Models
{
    public class EditUserViewModel
    {
        public Guid ImageId { get; internal set; }
        public IFormFile ImageFile { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string Address { get; internal set; }
        public string PhoneNumber { get; internal set; }
        public string Id { get; internal set; }

        public string ImageFullPath { get; set; }
        public string Nickname { get;  set; }
    }
}
