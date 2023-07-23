using System;
using System.Globalization;
using System.Text;
using System.Diagnostics;

namespace _30_special_string_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            //StringConversion();
            //StringAsArray();
            //EscapeString();
            //AppendingStrings();
            //InterpolationAndLiteral();
            PadAndTrim();
        }
        private static void StringConversion()
        {
            string testString = "This iS tHe FBI caLLinG!";
            TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
            string result;

            result = testString.ToLower();
            Console.WriteLine(result);

            result = testString.ToUpper();
            Console.WriteLine(result);

            result = currentTextInfo.ToTitleCase(testString);
            Console.WriteLine(result);


        }

        private static void StringAsArray()
        {
            string testString = "Tommy";

            for (int i = 0; i < testString.Length; i++)
            {
                Console.WriteLine(testString[i]);
            }
        }

        private static void EscapeString()
        {
            string results;
            results = "this is my \"test\" solution.";
            Console.WriteLine(results);

            results = "C:\\Demo\\Text.txt";
            Console.WriteLine(results);

            results = @"C:\Demo\Text.txt";
            Console.WriteLine(results);
        }

        private static void AppendingStrings()
        {
            string firstName = "timsn";
            string lastName = "rodel";
            string results;


        results =firstName + ", my name is "+ firstName+ " " + lastName;
                Console.WriteLine(results);
            results = string.Format("{0},my namse is  {0} {1}", firstName, lastName);
            Console.WriteLine(results);

            results = $"{firstName},my nsme is {lastName} {lastName}";
            Console.WriteLine(results);
        }

        private static void InterpolationAndLiteral()
        {
            string testString = "Tim Corey";
            string results = $@"C:\Demo\{testString}\Test.txt";
            Console.WriteLine(results);
        }

        private static void PadAndTrim()
        {
            string testString = "        hello     ";
            string results;

            results = testString.trimStart();
            Console.WriteLine($"'{results}'");
        }
    }
}
