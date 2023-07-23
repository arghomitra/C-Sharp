
namespace hospital_dsps
{
    public class Person
    {

        // proparties
        public string Name { get; set; }
        public DateOnly Dob { get; set; }
        public string Role { get; set; }

        // Constructor
        // what you want to know when you ctreate a new instance
        public Person( string name, DateOnly dob, string role)
        {
            this.Name = name;
            this.Dob = dob;
            this.Role = role;
        }
        public Person(string name, DateOnly dob)
        {
            this.Name = name;
            this.Dob = dob;
        }
    }
}

