namespace Mersy.Repositories.Implementations.Cor
{
    using Infraestructure;
    using Mersy.Common.Entities;
    using Mersy.Repositories.Contracts.Cor;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class UserRepository : IUserRepository
    {
        public readonly ApplicationDbContext Context;

        public UserRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public bool UserExists(string key)
        {
            return Context.Users.Any(e => e.Id == key);
        }

        public Task<List<ApplicationUser>> FindUserByClause(Func<ApplicationUser, bool> selector = null)
        {
            var models = Context.Users
                .Where(selector ?? (s => true));

            return Task.Run(() => models.ToList());
        }

        public async Task<ApplicationUser> FindUserByIdAsync(string key)
        {
            var entity = await Context.Users.FindAsync(key);
            return entity;
        }

        public IQueryable<ApplicationUser> GetAllUsers()
        {
            // return this.context.Set<T>().AsNoTracking();
            return Context.Users.AsNoTracking();
        }

        public Task<ApplicationUser> GetUserByClause(Func<ApplicationUser, bool> selector = null)
        {
            var models = Context.Users
                .Where(selector ?? (s => true));

            return Task.Run(() => models.FirstOrDefault());
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string id)
        {
            var entity = await Context.Users.FindAsync(id);
            return entity;
        }

        public async Task<bool> SaveAllAsync()
        {
            return await Context.SaveChangesAsync() > 0;
        }

        public Task<bool> UserExistAsync(string id)
        {
            return Context.Users.AnyAsync(e => e.Id == id);
        }

        public IQueryable<ApplicationUser> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public IQueryable<ApplicationUser> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public IQueryable<ApplicationUser> GetAllDoctors()
        {
            throw new NotImplementedException();
        }

        public IQueryable<ApplicationUser> GetAllTeachers()
        {
            throw new NotImplementedException();
        }

        public IQueryable<ApplicationUser> GetAllPatients()
        {
            throw new NotImplementedException();
        }
    }
}
