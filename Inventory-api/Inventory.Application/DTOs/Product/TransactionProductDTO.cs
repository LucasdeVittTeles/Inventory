using System.ComponentModel.DataAnnotations;

namespace Inventory.Application.DTOs.Product
{
    public class TransactionProductDTO
    {

        [Required]
        public long TransactionId { get; set; }
        [Required]
        public long ProductId { get; set; }
        [Required]
        public long Amount { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }

    }
}
