using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface IPersonTypeRepository
    {

        Task<PersonType> GetByIdAsync(long id);
        Task<List<PersonType>> GetAllAsync();
        Task CreateAsync(PersonType personType);
        Task UpdateAsync(PersonType personType);

    }
}
