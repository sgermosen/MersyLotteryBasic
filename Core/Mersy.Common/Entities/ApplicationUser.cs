namespace Mersy.Common.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class ApplicationUser : IdentityUser
    {
        public string Imagen { get; set; }

        public string Nickname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Address { get; set; }

        public int Comission { get; set; }

        public string FullName => $"{Nickname} - {Name} ";
        public Owner Owner { get; set; }

        public bool IsAdmin { get; set; }
        public bool IsSupervisor { get; set; }
        public bool IsSeller { get; set; }
        public bool IsDisabled { get; set; }

        public ApplicationUser()
        {

        }

        public static ApplicationUser Create(Owner Owner,
           string Name, string Address, string PhoneNumber, string Email, string Nickname = "",
          bool IsAdmin = false, bool IsSupervisor = false,
          bool EmailConfirmed = true, bool IsSeller = false)//, long? shopId = null)
        {
            return new ApplicationUser
            {
                Nickname = Nickname,
                IsAdmin = IsAdmin,
                IsSupervisor = IsSupervisor,
                Owner = Owner,
                IsSeller = IsSeller,
                Name = Name,
                // ShopId = shopId,
                Address = Address,
                PhoneNumber = PhoneNumber,
                Email = Email,
                EmailConfirmed = EmailConfirmed,
                UserName = Email,
                IsDisabled = false
            };
        }

        public static ApplicationUser Update(string Id,
           string Name, string Address, string PhoneNumber, string Nickname, bool IsAdmin,
           bool IsSupervisor,
         bool IsSeller, bool TakeCommision
        )
        {
            return new ApplicationUser
            {
                Nickname = Nickname,
                IsAdmin = IsAdmin,
                IsSupervisor = IsSupervisor,
                IsSeller = IsSeller,
                Id = Id,
                Name = Name,
                Address = Address,
                PhoneNumber = PhoneNumber,
            };
        }
    }
}
