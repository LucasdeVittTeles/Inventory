using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Domain.Interfaces.Services;

namespace Inventory.Application.Services
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }


        private void ValidateFields(Product product)
        {

            product.Name != "" 

        }

        public Task<List<Product>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(long id)
        {

            Product product = await _repository.GetByIdAsync(id);

            if (product == null)
            {
                throw new KeyNotFoundException("Produto não encontrado.");
            }



            return product;

        }

        public async Task CreateAsync(Product product)
        {

            if (string.IsNullOrWhiteSpace(product.Name))
            {
                throw new ArgumentException("O nome do produto é obrigatório.");
            }

            await _repository.CreateAsync(product);
        }

        public async Task UpdateAsync(Product product)
        {
            await _repository.UpdateAsync(product);
        }

        public async Task DeleteAsync(long id)
        {
            await _repository.DeleteAsync(id);
        }

    }
}
