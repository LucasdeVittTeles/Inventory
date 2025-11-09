using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Services;

namespace Inventory.Application.Services
{
    public class CategoryService : ICategoryService
    {
        public Task CreateAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
