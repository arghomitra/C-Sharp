using System;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SearchingString();

        }
        private static void SearchingString()
        {
            string testString = "This is a test of the seach.Let's see how its testing out";
            bool resultBoolean;
            int resultInt;
            resultBoolean = testString.StartsWith("This is");
            Console.WriteLine($"Starts with \"This is\": {resultBoolean}");

            resultBoolean = testString.EndsWith("out");
            Console.WriteLine($"Starts with \"out\": {resultBoolean}");

            resultBoolean = testString.EndsWith("Work out");
            Console.WriteLine($"Starts with \"Works out\": {resultBoolean}");

            resultBoolean = testString.Contains("out");
            Console.WriteLine($"Starts with \"out\": {resultBoolean}");

            resultBoolean = testString.Contains("Work out");
            Console.WriteLine($"Starts with \"Works out\": {resultBoolean}");


            resultInt = testString.IndexOf("tests",11);
            Console.WriteLine($"Ïndex of \"test\": {resultInt}");
        }
    }
}
