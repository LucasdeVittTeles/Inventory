using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Services
{
    public interface IPersonTypeService
    {
        Task<List<PersonType>> GetAllAsync();
        Task<PersonType> GetByIdAsync(long id);
        Task CreateAsync(PersonType personType);
        Task UpdateAsync(PersonType personType);

    }
}
