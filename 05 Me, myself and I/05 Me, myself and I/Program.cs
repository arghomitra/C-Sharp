using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _05_Me__myself_and_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String singerName = Console.ReadLine();
            string singerNameLower = singerName.ToLower();
            String fileName = singerName.Trim().Replace(" ", "");

            string path = fileName + ".txt";
            StreamReader input = File.OpenText(path);

            string text = input.ReadToEnd();
            string textLower = text.ToLower();
            input.Close();

            Regex mypattern = new Regex(singerNameLower);
            MatchCollection matches = mypattern.Matches(text);
            Console.WriteLine($"{matches.Count} occurrences of {singerName}");

        }
    }
}
