using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Moc_exam
{
    internal class Program
    {
        static void questionA()
        {
            Console.WriteLine("input a array :");
            string[] array = Console.ReadLine().Split(" ");
            string[] reversed = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversed[array.Length - i - 1] = array[i];
            }


            for (int i = 0; i < reversed.Length; i++)
            {
                Console.Write(reversed[i] + " ");
            }
        }
        static void questionB()
        {
            string[] array = Console.ReadLine().Split("");

        }
        static void questionC()
        {
            StreamReader input = File.OpenText("names-1.txt");
            string line = input.ReadToEnd();
            input.Close();

            Regex pattern = new Regex(@"[a-z]*.[a-z]*\@");

            // regex ([^@]+)
            MatchCollection matches = pattern.Matches(line);

            string names = string.Empty;

            foreach (var item in matches)
            {

                    names = names + " " + item.ToString().Replace(".","").Replace("@","");
                
                
            }
            names = names.Trim();
            string[] array = names.Split(" ");

           int temp = 0;
           string output = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;
                string name = array[i];
                for (int j = 0; j < name.Length; j++)
                {
                    sum = sum + Convert.ToChar(name[j]);
                }
                if(sum >temp)
                {
                    output = name;
                    temp = sum;
                }
            }
            Console.WriteLine(output);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Which question you want to see?");
            string question = Console.ReadLine().ToUpper();

            switch (question)
            {
                case "A":
                    questionA();
                    break;
                case "B":
                    questionB();
                    break;
                case "C":
                    questionC();
                    break;
                default:
                    Console.WriteLine("noo");
                    break;
            
        }
    }
}
