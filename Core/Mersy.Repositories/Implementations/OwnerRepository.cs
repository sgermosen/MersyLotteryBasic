using Mersy.Infraestructure;
using Mersy.Repositories.Contracts.Cor;
using System.Threading.Tasks;

namespace Mersy.Repositories.Implementations.Cor
{
    using Mersy.Common.Entities;

    public class OwnerRepository : Repository<Owner>, IOwnerRepository
    {
        public OwnerRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<Owner> FullCreation(Owner entity)
        {
            await Context.Owners.AddAsync(entity);

            var user = ApplicationUser.Create(entity, entity.Name, entity.Address,
                entity.Tel, entity.Email, entity.Name, true, true, false, false);

            await Context.Users.AddAsync(user);
            await SaveAllAsync();
            return entity;
        }


    }
}
