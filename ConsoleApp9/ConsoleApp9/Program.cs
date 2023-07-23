using hospital_dsps;
using System;

namespace hospital_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("collin", new DateOnly(), "doctor");

            Console.WriteLine(person1.Name);
        }
    }
}
