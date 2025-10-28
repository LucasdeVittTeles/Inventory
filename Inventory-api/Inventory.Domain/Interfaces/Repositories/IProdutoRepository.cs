using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository
    {

        Task<Product> ObterPorIdAsync(Guid id);
        Task<List<Product>> ObterTodosAsync();
        Task AdicionarAsync(Product produto);
        Task AtualizarAsync(Product produto);
        Task RemoverAsync(Guid id);

    }
}
