
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace _05_Yellow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string hexColor = Console.ReadLine();
                int hexnumber = Convert.ToInt32(hexColor, 16);
                Color mycolor = ColorTranslator.FromOle(hexnumber);

                if (!mycolor.IsKnownColor)
                {
                    Console.WriteLine("colorless");
                    return;
                }

                //reading the file
                string text = File.ReadAllText("ColdPlay.txt");

                //StreamReader read = File.OpenText("ColdPlay.txt");
                //string text = read.ReadToEnd();
                //read.Close();

                Regex pattern = new Regex(@"\b" + mycolor.Name + @"\b", RegexOptions.IgnoreCase);
                MatchCollection matches = pattern.Matches(text);

                if (matches.Count > 0)

                {
                    Console.WriteLine($"It was all {mycolor.Name} ({matches.Count} matches)");
                }
                else
                {
                    Console.WriteLine($"It wasn't {mycolor.Name} at all");
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Wrong Input");
            }
            
           
        }
    }
}
