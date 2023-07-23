namespace my_hospital_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Person elka = new Person("Elka", new DateOnly(1991,2,12 ));
            Person jenny = new Person("Jenny", new DateOnly(1970, 7, 1));
            Person collin = new Person("Collin", new DateOnly(1995, 4, 24));
            Person jhon = new Person();


            Console.WriteLine(elka.Name);
            Console.WriteLine($"{jenny.Name} : {jenny.Role}");
            Console.WriteLine(collin.Role);
            Console.WriteLine(jhon.Name+"-"+jhon.Role);

            jhon.Name = "Jhanathan";
            jhon.Role = "Doctor";
            Console.WriteLine(jhon.Name + "-" + jhon.Role);

            elka.print();
            Console.WriteLine(elka.ToString());

            Console.WriteLine("\n");
            
            Console.WriteLine(elka);
            Console.WriteLine(jhon);
            Console.WriteLine(jenny);
            Console.WriteLine(collin);
            */

            Patient elke = new Patient("Elke", new DateOnly(1980, 4, 23), "Teacher Syndrome");
            Doctor jenny = new Doctor("Jenny", new DateOnly(1970, 1, 1), "Heart");
            Patient collin = new Patient("Collin", new DateOnly(1991, 4, 16), "Teacher Syndrome");
            Nurse josh = new Nurse("Josh", new DateOnly(2000, 1, 1), "Emergency");
            Person john = new Person();

            Console.WriteLine(elke);
            Console.WriteLine(jenny);
            Console.WriteLine(jenny);
            Console.WriteLine(collin);
            Console.WriteLine(josh);
            Console.WriteLine(john);

            Console.WriteLine();
            Console.WriteLine();
            List<Person> people = new List<Person>();
            people.Add(elke);
            people.Add(jenny);
            people.Add(collin);
            people.Add(josh);
            people.Add(john);

            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            Hospital hospital = new Hospital("AZ Sint-Maarten", people);

            Doctor bea = new Doctor("Bea", new DateOnly(1970, 1, 1), "Dermatology");
            hospital.AddPerson(bea);

            Console.WriteLine(hospital);

        }
    }
}