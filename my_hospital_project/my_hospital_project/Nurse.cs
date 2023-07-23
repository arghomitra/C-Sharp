using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_hospital_project
{
    public class Nurse : Person
    {
        public string Department { get; set; }

        public Nurse(string name, DateOnly birth, string department) : base(name,birth)
        {
            
            Department = department;
        }
    }
}
