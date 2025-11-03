using Microsoft.EntityFrameworkCore;
using Inventory.Domain.Entities;


namespace Inventory.Infrastructure.Data.Context
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonType> PersonType { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<TransactionProduct> TransactionProduct { get; set; }

    }
}
