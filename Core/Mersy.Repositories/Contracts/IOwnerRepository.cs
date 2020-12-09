namespace Mersy.Repositories.Contracts.Cor
{
    using Mersy.Common.Entities;
    using System.Threading.Tasks;

    public interface IOwnerRepository : IRepository<Owner>
    {
        Task<Owner> FullCreation(Owner entity);
    }
}
