﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace my_hospital_project
{
    public class Hospital
    {
        public string Name { get; set; }
        private List<Person> People { get; set; }

        public Hospital(string name)
        {
            Name = name;
            People = new List<Person>();

        }

        public Hospital(string name, List<Person> people)
        {
            Name = name;
            People = people;

        }

        public void AddPerson(Person person) // Person person
        {
            People.Add(person);
        }



        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            foreach (Person person in People)
            {
                if (person is Patient) patients.Add((Patient)person);
            }
            return patients;
        }


        public List<Person> GetStaff()
        {
            List<Person> staff = new List<Person>();
            foreach (Person person in People)
            {
                //or person is not Patient
                if (person is Doctor || person is Nurse) staff.Add(person);
            }
            return staff;
        }

        public override string ToString()
        {
            string s = "HOSPITAL " + Name + "\n";
            foreach (Person person in People)
            {
                s += " - " + person + "\n";
            }
            return s;
        }

    }
}
