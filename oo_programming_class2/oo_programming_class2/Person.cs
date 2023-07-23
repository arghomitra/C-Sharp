using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oo_programming_class2
{
    public class Person
    {
        public string Name { get; set; }
        private DateOnly Dob { get; set; }

        public string Role { get; set; }

        // Constructor
        public Person(string _name, DateOnly _dob, string _role)
        {
            Name = _name;
            Dob = _dob;
            Role = _role;

        }

        // Methods
        public void sayHello()
            {
            Console.WriteLine($"Hello,I am {Name}");
            }

        

    }
}
