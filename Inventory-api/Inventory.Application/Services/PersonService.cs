using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Services;

namespace Inventory.Application.Services
{
    public class PersonService : IPersonService
    {
        public Task CreateAsync(Person person)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Person>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
