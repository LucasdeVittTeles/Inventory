namespace Inventory.Domain.Entities
{
    public class PersonType
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<Person> Persons { get; set; }


        public PersonType()
        {
            Name = "";
        }

    }
}
