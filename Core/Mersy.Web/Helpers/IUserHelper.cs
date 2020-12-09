namespace Mersy.Web.Helpers
{
    using Mersy.Common.Entities;
    using Mersy.Common.Models;
    using Mersy.Web.Models;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public interface IUserHelper
    {
        Task<ApplicationUser> AddUserAsync(FacebookProfile model);
        string RemoveCharacters(string param);

        Task<IList<string>> GetUserRols(ApplicationUser user);


        Task<ApplicationUser> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(ApplicationUser user, string password);

        Task<PersonCreationViewModel> AddFullUserAsync(UsersViewModel vm, string password, Owner owner,
              string rootFolder, string folder, ApplicationUser userConected);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

        Task<IdentityResult> UpdateUserAsync(ApplicationUser user);

        Task<IdentityResult> UpdateEmailAsync(ApplicationUser user, string email, string token);


        Task<IdentityResult> ChangePasswordAsync(ApplicationUser user, string oldPassword, string newPassword);

        Task<SignInResult> ValidatePasswordAsync(ApplicationUser user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(ApplicationUser user, string roleName);

        Task<bool> IsUserInRoleAsync(ApplicationUser user, string roleName);

        Task<string> GenerateEmailConfirmationTokenAsync(ApplicationUser user);

        Task<IdentityResult> ConfirmEmailAsync(ApplicationUser user, string token);

        Task<ApplicationUser> GetUserByIdAsync(string userId);

        Task<string> GeneratePasswordResetTokenAsync(ApplicationUser user);
        Task<string> GenerateEmailChangeTokenAsync(ApplicationUser user, string email);

        Task<IdentityResult> ResetPasswordAsync(ApplicationUser user, string token, string password);

        Task<ApplicationUser> AddClaim(ApplicationUser user, Claim claim);

        Task<List<ApplicationUser>> GetAllUsersAsync(long ownerId);

        Task<List<ApplicationUser>> GetAllUsersNoLockoutAsync(long ownerId);

        Task<List<ApplicationUser>> GetAllEmployeesAsync(long ownerId);

        Task<List<ApplicationUser>> GetAllDoctorsNoLockoutAsync(long ownerId);

        Task<List<ApplicationUser>> GetAllTeachersNoLockoutAsync(long ownerId);

        Task<List<ApplicationUser>> GetAllStudentsNoLockoutAsync(long ownerId);

        Task<List<ApplicationUser>> GetAllPatientsNoLockoutAsync(long ownerId);

        Task RemoveUserFromRoleAsync(ApplicationUser user, string roleName);

        Task DeleteUserAsync(ApplicationUser user);
        Task<bool> DisabledUserAsync(ApplicationUser user);
        Task<ApplicationUser> GetUserAsync(Guid userId);
        // Task AddUserAsync(FacebookProfile model);
    }
}
