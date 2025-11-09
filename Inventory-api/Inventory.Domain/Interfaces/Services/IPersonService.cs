using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Services
{
    public interface IPersonService
    {
        Task<List<Person>> GetAllAsync();
        Task<Person> GetByIdAsync(long id);
        Task CreateAsync(Person person);
        Task UpdateAsync(Person person);
        Task DeleteAsync(long id);

    }
}
