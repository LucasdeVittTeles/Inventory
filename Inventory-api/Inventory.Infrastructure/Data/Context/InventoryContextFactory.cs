using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Inventory.Infrastructure.Data.Context
{
    public class InventoryContextFactory : IDesignTimeDbContextFactory<InventoryContext>
    {
        public InventoryContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<InventoryContext>();


            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=inventoryDb;User Id=sa;Password=Strong@12345;TrustServerCertificate=True;");

            return new InventoryContext(optionsBuilder.Options);
        }
    }
}