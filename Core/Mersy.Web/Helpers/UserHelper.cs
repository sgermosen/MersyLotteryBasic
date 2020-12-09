using System;

namespace Mersy.Web.Helpers
{
    using Mersy.Common.Entities;
    using Mersy.Common.Models;
    using Mersy.Infraestructure;
    using Mersy.Web.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class UserHelper : IUserHelper
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;
        private readonly RecordsHelper recordHelper;

        public UserHelper(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
            recordHelper = new RecordsHelper(context);
        }

        public string RemoveCharacters(string param)
        {
            param = param.Replace("(", "");
            param = param.Replace(")", "");
            param = param.Replace("-", "");
            param = param.Replace(" ", "");
            return param;
        }

        public async Task<bool> DisabledUserAsync(ApplicationUser user)
        {
            try
            {
                var lockoutEndDate = new DateTime(2999, 01, 01);
                await _userManager.SetLockoutEnabledAsync(user, true);
                await _userManager.SetLockoutEndDateAsync(user, lockoutEndDate);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public async Task<IdentityResult> AddUserAsync(ApplicationUser user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        //     var result = await UserHelper.AddFullUserAsync(vm, "824455", owner, "images", "Employees", userConected);

        public async Task<PersonCreationViewModel> AddFullUserAsync(UsersViewModel vm, string password, Owner owner,
            string rootFolder, string folder, ApplicationUser userConected)
        {
            var newUser = ApplicationUser.Create(owner, vm.Name,
                 vm.Address, vm.PhoneNumber,
                  vm.Email, vm.Nickname, vm.IsAdmin, vm.IsSupervisor, 
                true, vm.IsSeller );
            try
            {
                var result = await AddUserAsync(newUser, password);
                if (result != IdentityResult.Success)
                {
                    return new PersonCreationViewModel { Success = false };
                }

                await AddClaim(newUser, new Claim("OwnerId", owner.Id.ToString()));
                // await UserHelper.AddClaim(user, new Claim("ShopId", shop.Id.ToString()));
                await AddUserToRoleAsync(newUser, "User");

                //

                var path = string.Empty;

                if (vm.ImageFile != null)
                { 
                    path = FileHelper.UploadFile(vm.ImageFile, path, rootFolder, folder, ref owner);
                    _context.Update(owner);
                }

                vm.Imagen = path;

                if (vm.IsAdmin)
                {
                    await CheckRoleAsync("Admin");
                    await AddUserToRoleAsync(newUser, "Admin");
   }
               
                if (vm.IsSeller)
                {
                    await CheckRoleAsync("Seller");
                    await AddUserToRoleAsync(newUser, "Seller");
                }

                if (vm.IsSupervisor)
                {
                    await CheckRoleAsync("Supervisor");
                    await AddUserToRoleAsync(newUser, "Supervisor");
                }

                await _context.SaveChangesAsync();

                var perView = new PersonCreationViewModel { Success = true };

                return perView;
            }
            catch (Exception)
            {
                return new PersonCreationViewModel { Success = false };
            }
        }

        public async Task AddUserToRoleAsync(ApplicationUser user, string roleName)
        {
            var rol = await _userManager.IsInRoleAsync(user, roleName);
            if (!rol)
            {
                await _userManager.AddToRoleAsync(user, roleName);
            }

        }

        public async Task<IdentityResult> ChangePasswordAsync(ApplicationUser user, string oldPassword, string newPassword)
        {
            return await _userManager.ChangePasswordAsync(user, oldPassword, newPassword);
        }

        public async Task CheckRoleAsync(string roleName)
        {
            var roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
                await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = roleName
                });
            }
        }

        public async Task<ApplicationUser> GetUserByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }
        public async Task<IList<string>> GetUserRols(ApplicationUser user)
        {
            var userRoles = await _userManager.GetRolesAsync(user);
            return userRoles;
        }

        public async Task<bool> IsUserInRoleAsync(ApplicationUser user, string roleName)
        {
            return await _userManager.IsInRoleAsync(user, roleName);
        }

        public async Task<SignInResult> LoginAsync(LoginViewModel model)
        {
            return await _signInManager.PasswordSignInAsync(
                model.Username,
                model.Password,
                model.RememberMe,
                false);
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> UpdateUserAsync(ApplicationUser user)
        {
            var usr = await GetUserByIdAsync(user.Id);
            usr.Name = user.Name;
            usr.Nickname = user.Nickname;

            usr.Address = user.Address;
            usr.IsAdmin = user.IsAdmin;
            usr.IsSupervisor = user.IsSupervisor;
            usr.IsSeller = user.IsSeller;
            usr.PhoneNumber = user.PhoneNumber; 

            return await _userManager.UpdateAsync(usr);
        }

        public async Task<IdentityResult> UpdateEmailAsync(ApplicationUser user, string email, string token)
        {
            return await _userManager.ChangeEmailAsync(user, email, token);
        }

        public async Task<SignInResult> ValidatePasswordAsync(ApplicationUser user, string password)
        {
            return await _signInManager.CheckPasswordSignInAsync(
                user,
                password,
                false);
        }

        public async Task<IdentityResult> ConfirmEmailAsync(ApplicationUser user, string token)
        {
            return await _userManager.ConfirmEmailAsync(user, token);
        }

        public async Task<string> GenerateEmailConfirmationTokenAsync(ApplicationUser user)
        {
            return await _userManager.GenerateEmailConfirmationTokenAsync(user);
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string userId)
        {
            return await _userManager.FindByIdAsync(userId);
        }

        public async Task<string> GeneratePasswordResetTokenAsync(ApplicationUser user)
        {
            return await _userManager.GeneratePasswordResetTokenAsync(user);
        }

        public async Task<string> GenerateEmailChangeTokenAsync(ApplicationUser user, string email)
        {
            return await _userManager.GenerateChangeEmailTokenAsync(user, email);
        }

        public async Task<IdentityResult> ResetPasswordAsync(ApplicationUser user, string token, string password)
        {
            return await _userManager.ResetPasswordAsync(user, token, password);
        }

        public async Task<ApplicationUser> AddClaim(ApplicationUser user, Claim claim)
        {
            await _userManager.AddClaimAsync(user, claim);
            return user;
        }

        public async Task<List<ApplicationUser>> GetAllUsersNoLockoutAsync(long ownerId)
        {
            return await _userManager.Users
                .Where(p => p.Owner.Id == ownerId
                            && (p.LockoutEnd == null || p.LockoutEnd <= DateTime.Now))
                .Include(p => p.Owner)
                .OrderBy(u => u.Name)
                .ThenBy(u => u.Nickname)
                .ToListAsync();
        }
        //public async Task<List<ApplicationUser>> GetAllEmployeesAsync(long ownerId)
        //{
        //    return await _userManager.Users
        //        .Where(p => p.Owner.Id == ownerId && p.IsEmployee
        //                    && (p.LockoutEnd == null || p.LockoutEnd <= DateTime.Now))
        //        .Include(p => p.Owner)
        //        .OrderBy(u => u.Name)
        //        .ThenBy(u => u.Lastname)
        //        .ToListAsync();
        //}
        //public async Task<List<ApplicationUser>> GetAllDoctorsNoLockoutAsync(long ownerId)
        //{
        //    return await _userManager.Users
        //        .Where(p => p.Owner.Id == ownerId && p.IsDoctor
        //                    && (p.LockoutEnd == null || p.LockoutEnd <= DateTime.Now))
        //        .Include(p => p.Owner)
        //        .OrderBy(u => u.Name)
        //        .ThenBy(u => u.Lastname)
        //        .ToListAsync();
        //}
        //public async Task<List<ApplicationUser>> GetAllTeachersNoLockoutAsync(long ownerId)
        //{
        //    return await _userManager.Users
        //        .Where(p => p.Owner.Id == ownerId && p.IsTeacher
        //                    && (p.LockoutEnd == null || p.LockoutEnd <= DateTime.Now))
        //        .Include(p => p.Owner)
        //        .OrderBy(u => u.Name)
        //        .ThenBy(u => u.Lastname)
        //        .ToListAsync();
        //}
        //public async Task<List<ApplicationUser>> GetAllStudentsNoLockoutAsync(long ownerId)
        //{
        //    return await _userManager.Users
        //        .Where(p => p.Owner.Id == ownerId && p.IsStudent
        //                    && (p.LockoutEnd == null || p.LockoutEnd <= DateTime.Now))
        //        .Include(p => p.Owner)
        //        .OrderBy(u => u.Name)
        //        .ThenBy(u => u.Lastname)
        //        .ToListAsync();
        //}
        //public async Task<List<ApplicationUser>> GetAllPatientsNoLockoutAsync(long ownerId)
        //{
        //    return await _userManager.Users
        //        .Where(p => p.Owner.Id == ownerId && p.IsPatient
        //                    && (p.LockoutEnd == null || p.LockoutEnd <= DateTime.Now))
        //        .Include(p => p.Owner)
        //        .OrderBy(u => u.Name)
        //        .ThenBy(u => u.Lastname)
        //        .ToListAsync();
        //}
        public async Task<List<ApplicationUser>> GetAllUsersAsync(long ownerId)
        {
            return await _userManager.Users.Where(p => p.Owner.Id == ownerId)
                .Include(p => p.Owner)
                .OrderBy(u => u.Name)
                .ThenBy(u => u.Nickname)
                .ToListAsync();
        }

        public async Task RemoveUserFromRoleAsync(ApplicationUser user, string roleName)
        {
            await _userManager.RemoveFromRoleAsync(user, roleName);
        }

        public async Task DeleteUserAsync(ApplicationUser user)
        {
            await _userManager.DeleteAsync(user);
        }

        public async Task<List<ApplicationUser>> GetAllEmployeesAsync(long ownerId)
        {
            return await _userManager.Users.Where(p => p.Owner.Id == ownerId)
                    .Include(p => p.Owner)
                    .OrderBy(u => u.Name)
                    .ThenBy(u => u.Nickname)
                    .ToListAsync();
        }

        public async Task<List<ApplicationUser>> GetAllDoctorsNoLockoutAsync(long ownerId)
        {
            return await _userManager.Users.Where(p => p.Owner.Id == ownerId)
                 .Include(p => p.Owner)
                 .OrderBy(u => u.Name)
                 .ThenBy(u => u.Nickname)
                 .ToListAsync();
        }

        public async Task<List<ApplicationUser>> GetAllTeachersNoLockoutAsync(long ownerId)
        {
            return await _userManager.Users.Where(p => p.Owner.Id == ownerId)
                .Include(p => p.Owner)
                .OrderBy(u => u.Name)
                .ThenBy(u => u.Nickname)
                .ToListAsync();
        }

        public async Task<List<ApplicationUser>> GetAllStudentsNoLockoutAsync(long ownerId)
        {
            return await _userManager.Users.Where(p => p.Owner.Id == ownerId)
               .Include(p => p.Owner)
               .OrderBy(u => u.Name)
               .ThenBy(u => u.Nickname)
               .ToListAsync();
        }

        public async Task<List<ApplicationUser>> GetAllPatientsNoLockoutAsync(long ownerId)
        {
            return await _userManager.Users.Where(p => p.Owner.Id == ownerId)
                 .Include(p => p.Owner)
                 .OrderBy(u => u.Name)
                 .ThenBy(u => u.Nickname)
                 .ToListAsync();
        }
        public async Task<ApplicationUser> GetUserAsync(Guid userId)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Id == userId.ToString());
        }

        public async Task<ApplicationUser> AddUserAsync(FacebookProfile model)
        {
            var userEntity = new ApplicationUser
            {
                Address = "...",
                Email = model.Email,
                Name = model.FirstName,
                // LastName = model.LastName,
                //  ImageFacebook = model.Picture?.Data?.Url,
                PhoneNumber = "...",
                UserName = model.Email,
                //  UserType = UserType.User,
                // LoginType = LoginType.Facebook,
                // ImageId = Guid.Empty
            };

            IdentityResult result = await _userManager.CreateAsync(userEntity, model.Id);
            if (result != IdentityResult.Success)
            {
                return null;
            }

            ApplicationUser newUser = await GetUserByEmailAsync(model.Email);
            await AddUserToRoleAsync(newUser, "Facebook");// userEntity.UserType.ToString());
            return newUser;
        }

    }
}
