using System;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
using System.Text;


namespace longest_word
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PadAndTrim();




        }
        private static void PadAndTrim()
        {
            string testString = "        hello     ";
            string results;

            results = testString.TrimEnd();
            Console.WriteLine($"'{results}'");

            results = testString.TrimStart();
            Console.WriteLine($"'{results}'");

            results = testString.Trim();
            Console.WriteLine($"'{results}'");

            testString = "1.15";
            results = testString.PadLeft(10,'0') ;
            Console.WriteLine(results);

            testString = "1.15";
            results = testString.PadRight(10, '0');
            Console.WriteLine(results);
        }
    }
}
