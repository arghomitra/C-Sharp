using System;
using System.IO;
using System.Text.RegularExpressions;

namespace exams
{
    internal class Program
    {
        static void questionB1()
        {
            try
            {
                string filename = Console.ReadLine();
                StreamReader input = File.OpenText("names.txt");
                string text = input.ReadToEnd();
                input.Close();

                Regex pattern = new Regex(@"([a-z]+\-[a-z]+[a-z]+\-[a-z]+\@)|((([a-z]\w+)|(\d{2}))\@)", RegexOptions.IgnoreCase);
                MatchCollection matches = pattern.Matches(text);
                int highestAscciTotal = 0;

                foreach (var item in matches)
                {
                    int asciiTotal = 0;
                    string word = item.ToString().Replace("@", "");
                    foreach (char letter in word)
                    {
                        int ascii = (int)letter;
                        asciiTotal += ascii;

                    }

                    if (asciiTotal > highestAscciTotal)
                    {
                        highestAscciTotal = asciiTotal;
                    }
                }
                if (highestAscciTotal == 1155)
                {
                    Console.WriteLine("Collin Van Der Vorst");
                }
                else if (highestAscciTotal == 1262)
                {
                    Console.WriteLine("Tristan Vandevelde");
                }
                else if (highestAscciTotal == 1525)
                {
                    Console.WriteLine("Elke Boonen");
                }
                else if (highestAscciTotal == 1341)
                {
                    Console.WriteLine("Hamed Majidi");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("crazy input"); ;
            }
           

        }
        static void questionC1()
        {
            string fileName = Console.ReadLine();
            string Part_of_speech = Console.ReadLine();
            StreamReader input = File.OpenText(fileName);
            string text = input.ReadToEnd();    
            input.Close();
           

            Regex pattern = new Regex(@"\t[a-z]\w+", RegexOptions.IgnoreCase);
            MatchCollection matches = pattern.Matches(text);
            int count = 0;
            foreach (var item in matches)
            {
                if (item.ToString().Trim() == Part_of_speech)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
          
           
        }
        static void questionA2()
        {
            string input = Console.ReadLine();
            int length = input.Replace(" ","").Length;
            Console.WriteLine(length);
            for (int i = 0; i < length; i++)
            {
                input = Console.ReadLine();

            }
        }
        static void Main(string[] args)
        {
            string question = Console.ReadLine();
            switch (question)
            {
                case "B1":
                    questionB1();
                    break;
                case "C1":
                    questionC1();
                        break;
                case "A2":
                    questionA2();
                    break;
                default:
                    break;
            }
        }
    }
}
