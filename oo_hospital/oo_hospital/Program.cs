using static oo_hospital.person;

namespace oo_hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person elke = new Person("Elke", new DateOnly(1980, 4, 23), "Patient");
            Person jenny = new Person("Jenny", new DateOnly(1970, 1, 1), "Doctor");
            Person collin = new Person("Collin", new DateOnly(1991, 4, 16), "Patient");
            Person josh = new Person("Josh", new DateOnly(2000, 1, 1), "Nurse");
            Person john = new Person();


            Console.WriteLine(elke.Name);
            Console.WriteLine($"{jenny.Name}: {jenny.Role}");
            Console.WriteLine(collin.Role);
            Console.WriteLine(josh.Name + " " + josh.Role);

            john.Name = "Johanna";
            john.Role = "Doctor";
            Console.WriteLine(john.Name + " " + john.Role);
        }
    }
}