using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace file_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*StreamReader input = File.OpenText("Beyonce.txt");
            string line = input.ReadLine();
            

            while (line != null)
            {
                line = input.ReadLine();
                string[] parts = line.Split(";"); // only read lyrix

                Console.WriteLine(parts[5]);
                
            }


            input.Close();*/
            /*StreamReader input = File.OpenText("Beyonce.txt");
            string fullText = input.ReadToEnd();
            input.Close();

            Regex pattarn = new Regex(@"\bkiss\b");
            MatchCollection match = pattarn.Matches(fullText);

            int count = match.Count;
            Console.WriteLine(count);
            */
            StreamReader input = File.OpenText("Beyonce.txt");
            string line = input.ReadToEnd();
            input.Close();

            Regex pattern = new Regex(@"\b[a-z]\b");
            MatchCollection match =pattern.Matches(line);


            Console.Write(match.Count);

            




        }
    }
}
