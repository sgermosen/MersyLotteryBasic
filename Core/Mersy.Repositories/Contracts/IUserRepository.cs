namespace Mersy.Repositories.Contracts.Cor
{
    using Mersy.Common.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IUserRepository
    {
        IQueryable<ApplicationUser> GetAllUsers();

        IQueryable<ApplicationUser> GetAllEmployees();

        IQueryable<ApplicationUser> GetAllStudents();

        IQueryable<ApplicationUser> GetAllDoctors();

        IQueryable<ApplicationUser> GetAllTeachers();

        IQueryable<ApplicationUser> GetAllPatients();

        Task<ApplicationUser> GetUserByIdAsync(string id);

        Task<bool> UserExistAsync(string id);

        bool UserExists(string key);

        Task<ApplicationUser> FindUserByIdAsync(string key);

        Task<List<ApplicationUser>> FindUserByClause(Func<ApplicationUser, bool> selector = null);

        Task<ApplicationUser> GetUserByClause(Func<ApplicationUser, bool> selector = null);

    }
}
