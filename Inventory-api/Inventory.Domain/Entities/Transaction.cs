using Inventory.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Domain.Entities
{
    public class Transaction
    {

        public long Id { get; set; }
        [Required]
        public TransactionType TransactionType { get; set; }
        [Required]
        public long PartnerId { get; set; }
        [Required]
        public long RegisteredById { get; set; }
        public DateTime TransactionDate { get; set; }

    }
}
