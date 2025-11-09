using System.ComponentModel.DataAnnotations;

namespace Inventory.Domain.Entities

{
    public class TransactionProduct
    {
        public long Id { get; set; }
        [Required]
        public long TransactionId { get; set; }
        [Required]
        public long ProductId { get; set; }
        [Required]
        public long Amount { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        public Transaction Transaction { get; set; }
        public Product Product { get; set; }

    }
}
