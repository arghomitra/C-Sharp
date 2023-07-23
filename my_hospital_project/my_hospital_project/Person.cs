using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_hospital_project
{
    public class Person
    {
        public string Name { get; set; }
        private DateOnly Birth { get; set; }

        public string Role { get; set; }

        public Person(string name, DateOnly birth)
        {
            Name = name;
            Birth = birth;
            
        }

        public Person()
        {
            Name = "Jhon Doe";
            Birth = new DateOnly(2000,1,3);
            
        }

        public void print()
        {
            Console.WriteLine($"{Name}-{Birth}");
        }

        public override string ToString()
        {
            return $"{Name}-{Birth}";

        }
    }

}
