
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace _07_word
{
    internal class Program
    {
        static void Main(string[] args)
        { string word = "doeas";
            StreamReader input = File.OpenText("BTS.txt");
            string allText = input.ReadToEnd();
            input.Close();

            //string[] words = allText.Split(' ');
            //foreach (var item in words)

            //string text = string.Empty;    
            //{if (item.Length == 8)
            //    {

            //        string 
            //        string text++;
            //        for (int i = 0; i < text.Length; i++)
            //        {

            //        }



            //    }
            
            Regex pattarn = new Regex(@"[d|o|e|a|s]\w+");
            MatchCollection match = pattarn.Matches(allText);
            string items = string.Empty;
            foreach (var item in match)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
