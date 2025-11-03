namespace Inventory.Domain.Entities

{
    public class Person
    {

        public long Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public int PersonTypeId { get; set; }

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
