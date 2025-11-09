using System.ComponentModel.DataAnnotations;

namespace Inventory.Domain.Entities
{
    public class PersonType
    {

        public long Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public ICollection<Person> Persons { get; set; }

        public PersonType()
        {
            Name = "";
        }

    }
}
