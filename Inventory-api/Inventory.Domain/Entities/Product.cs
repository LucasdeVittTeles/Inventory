using System.ComponentModel.DataAnnotations;

namespace Inventory.Domain.Entities

{
    public class Product
    {
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public int InventoryAmount { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public long CategoryId { get; set; }
        public Category Category { get; set; }


        public Product()
        {
            Name = "";
            Description = "";
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsActive = true;
        }

    }
}
