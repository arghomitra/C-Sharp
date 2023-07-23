using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_hospital_project
{
    public class Doctor : Person
    {
        public string Speciality { get; set; }

        public Doctor(string name,DateOnly birth, string speciality) : base(name,birth)
        {
            
            Speciality = speciality;
        }
    }
}
