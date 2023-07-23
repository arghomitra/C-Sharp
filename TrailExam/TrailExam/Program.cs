using System;
using System.Globalization;
using System.IO;
using System.Threading.Channels;

namespace TrailExam
{
    internal class Program
    {
        static void questionA()
        {
            StreamReader input = File.OpenText("names.txt");
            string fileText = input.ReadToEnd();
            input.Close();
            Console.WriteLine(fileText);
        }
        static void questionB()
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split();
            Console.WriteLine(inputArray[2]);

        }
        static void Main(string[] args)
        {
            string question = Console.ReadLine();
            switch (question)
            {
                case "trail1":
                    questionA();
                    break;
                case "trail2":
                questionB();
                    break;

                default:
                    break;
            }
        }
    }
}
