using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface IPersonRepository
    {

        Task<Person> GetByIdAsync(long id);
        Task<List<Person>> GetAllAsync();
        Task CreateAsync(Person person);
        Task UpdateAsync(Person person);
        Task DeleteAsync(long id);
    }
}
