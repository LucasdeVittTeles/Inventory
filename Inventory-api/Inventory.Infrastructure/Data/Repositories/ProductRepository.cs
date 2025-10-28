using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructure.Data.Repositories
{
    public class ProductRepository : IProdutoRepository
    {


        private readonly InventoryContext _context;

        public Task AdicionarAsync(Product produto)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarAsync(Product produto)
        {
            throw new NotImplementedException();
        }

        public Task<Product> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoverAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
