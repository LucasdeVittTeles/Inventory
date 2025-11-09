using System.ComponentModel.DataAnnotations;

namespace Inventory.Application.DTOs.Product

{
    public class ProductDTO
    {

        [Required]
        [StringLength(100, ErrorMessage = "O nome deve ter até 100 caracteres")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "O nome deve ter até 100 caracteres")]
        public string Description { get; set; }

        public int InventoryAmount { get; set; }

        [Required]
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        [Required]
        public long CategoryId { get; set; }

    }
}
