using Inventory.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Application.DTOs.Product
{
    public class TransactionDTO
    {

        [Required]
        public TransactionType TransactionType { get; set; }

        [Required]
        public long PartnerId { get; set; }

        [Required]
        public long RegisteredById { get; set; }

    }
}
