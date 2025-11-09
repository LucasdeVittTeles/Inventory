using System.ComponentModel.DataAnnotations;

namespace Inventory.Application.DTOs.Product
{  
    public class CategoryDTO
    {

        [Required]
        [MaxLength(100, ErrorMessage = "O nome deve ter até 100 caracteres")]
        public string Name { get; set; }

        [MaxLength(500, ErrorMessage = "A descrição deve ter até 500 caracteres")]
        public string Description { get; set; }

    }
}
