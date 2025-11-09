using System.ComponentModel.DataAnnotations;

namespace Inventory.Domain.Entities

{
    public class Person
    {

        public long Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Email { get; set; }

        public string Phone { get; set; }

        [MaxLength(250)]
        public string Address { get; set; }

        [Required]
        public long PersonTypeId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool IsActive { get; set; }

        public PersonType PersonType { get; set; }


        public Person()
        {
            Name = "";
            Email = "";
            Phone = "";
            Address = "";
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsActive = true;
        }

    }
}
