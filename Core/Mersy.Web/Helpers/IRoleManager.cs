using Mersy.Domain.Entities;
using Mersy.Web.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersy.Web.Helpers
{
    public interface IRoleManager
    {
        List<IdentityRole> GetAllRolesAsync();
        Task<IdentityResult> CreateAsync(ApplicationRoleViewModel model);
        Task<IdentityResult> DeleteAsync(ApplicationRoleViewModel model);
    }
    public class RoleManager : IRoleManager
    {
        private readonly RoleManager<IdentityRole> roleManager;
        public RoleManager(RoleManager<IdentityRole> roleManager)
        {

            this.roleManager = roleManager;

        }
        public Task<IdentityResult> CreateAsync(ApplicationRoleViewModel model)
        {
            IdentityRole role = new IdentityRole();
            role.Name = model.RoleName;
            return this.roleManager.CreateAsync((role));
        }
        public Task<IdentityResult> DeleteAsync(ApplicationRoleViewModel model)
        {
            IdentityRole role = new IdentityRole();
            role.Name = model.RoleName;
            return this.roleManager.DeleteAsync((role));
        }

        public List<IdentityRole> GetAllRolesAsync()
        {
            var roles =   this.roleManager.Roles.ToList();
            return roles;
        }

    }
}
