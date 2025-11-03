using Inventory.Domain.Enums;

namespace Inventory.Domain.Entities
{
    public class Transaction
    {

        public long Id { get; set; }
        public TransactionType TransactionType { get; set; }
        public long PartnerId { get; set; }
        public long RegisteredById { get; set; }
        public DateTime TransactionDate { get; set; }

    }
}
