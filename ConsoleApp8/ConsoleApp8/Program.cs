using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //StreamReader file = File.OpenText("Russian01.txt");
            //string line = file.ReadLine();
            string store = " \tкоторый \t";
            /*while (line!=null)
            {
                line = file.ReadLine();
                Regex pattern = new Regex(@"[verb]");
                MatchCollection matches = pattern.Matches(line);
                if (matches.Count>0)
                {
                    store += line + "\n";
                }
            }*/
            Regex pattern1 = new Regex(@"\t[]\w+\t");
            MatchCollection matches1 = pattern1.Matches(store);
            foreach (var item in matches1)
            {
                Console.WriteLine(item.ToString());
            }


        }
    }
}
