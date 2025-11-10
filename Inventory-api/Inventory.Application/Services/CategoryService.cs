using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Domain.Interfaces.Services;

namespace Inventory.Application.Services
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        private void ValidateFields(Person person)
        {

            if (person == null)
                throw new ArgumentNullException(nameof(person), "A pessoa não pode ser nula.");

            if (string.IsNullOrWhiteSpace(person.Name))
                throw new ArgumentException("O nome da pessoa é obrigatório.");

        }

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
            return _repository.GetAllAsync();
        }

        public async Task<Category> GetByIdAsync(long id)
        {

            Category category = await _repository.GetByIdAsync(id);

            if (category == null)
            {
                throw new KeyNotFoundException("Categoria não encontrada.");
            }

            return category;
        }

        public Task UpdateAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
