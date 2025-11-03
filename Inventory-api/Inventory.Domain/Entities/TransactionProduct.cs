namespace Inventory.Domain.Entities

{
    public class TransactionProduct
    {
        public long Id { get; set; }
        public long TransactionId { get; set; }
        public long ProductId { get; set; }
        public long Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public Transaction Transaction { get; set; }
        public Product Product { get; set; }

    }
}
