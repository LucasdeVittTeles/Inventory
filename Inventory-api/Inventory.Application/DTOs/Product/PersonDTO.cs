using System.ComponentModel.DataAnnotations;

namespace Inventory.Application.DTOs.Product
{
    public class PersonDTO
    {

        [Required]
        [StringLength(100, ErrorMessage = "O nome deve ter até 100 caracteres")]
        public string Name { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "O email deve ter até 250 caracteres")]
        public string Email { get; set; }

        public string Phone { get; set; }

        [StringLength(250, ErrorMessage = "O endereço deve ter até 250 caracteres")]
        public string Address { get; set; }

        [Required]
        public int PersonTypeId { get; set; }

        public bool IsActive { get; set; }



    }
}
