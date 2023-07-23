using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oo_hospital
{
    
        public class Person
        {
            public string Name { get; set; }
            private DateOnly Birth { get; set; }
            public string Role { get; set; }

            public Person(string name, DateOnly birth, string role)
            {
                Name = name;
                Birth = birth;
                Role = role;
            }

            public Person()
            {
                Name = "John Doe";
                Birth = new DateOnly(1, 1, 2000);
                Role = "Patient";
            }
        }
    
}
