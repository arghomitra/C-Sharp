using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml;

namespace students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * *********SINGLE LADIES**********

            StreamReader file =File.OpenText("Beyonce.txt");
            string fileText = file.ReadToEnd().Replace(";"," ").ToLower();
            file.Close();
            

            Regex pattern1 = new Regex(@"\bgirls?\b");
            MatchCollection girl = pattern1.Matches(fileText);
            Console.WriteLine(girl.Count);

            Regex pattern2 = new Regex(@"\blad(y|ies)\b");
            MatchCollection ladies = pattern2.Matches(fileText);
            Console.WriteLine(ladies.Count);

            Regex pattern3 = new Regex(@"\bwom(a|e)n\b");
            MatchCollection women = pattern3.Matches(fileText);
            Console.WriteLine(women.Count);
            */
            /*
            string hexColor = "FFFF";
            int hexNumber = Convert.ToInt32(hexColor,16);
            Console.WriteLine(hexNumber);

            Color mycolor = ColorTranslator.FromOle(hexNumber);
            Console.WriteLine(mycolor.Name);
            */


            /*
            StreamReader file = File.OpenText("Coldplay.txt");
            string fileText = file.ReadToEnd().Replace(";", " ").ToLower();
            file.Close();
            Console.WriteLine(fileText);

            Regex pattern3 = new Regex(@"\sYellow\s", RegexOptions.IgnoreCase);
            MatchCollection women = pattern3.Matches(fileText);
            Console.WriteLine(women.Count);
            */
            /*
            string line = "Don'''t put all your eggs in one basket!!!";
            string result = string.Empty;

            foreach (char item in line)
            {
                int ascii = Convert.ToInt32(item);
               
                if (ascii>=33 && ascii <=63)
                {
                    if (!result.Contains(item))
                    {
                        result += item;
                    }
                }
                else
                {
                    result = result + item;
                }
            }
            Console.WriteLine(result);

            */
            

            StreamReader input = File.OpenText("KatyPerry.txt");
            string text = input.ReadToEnd().Replace(";"," ");
            input.Close();


            Regex pattern = new Regex(@"[a-z]\w+");
            MatchCollection matches = pattern.Matches(text);

            string longestWord = string.Empty;
            foreach (var item in matches)
            {
                if (item.ToString().Length>longestWord.Length)
                {
                    longestWord = item.ToString();
                }
                
            }
            Console.WriteLine(longestWord);



        }


        private static object FromOle(object hexnumber)
        {
            throw new NotImplementedException();
        }
    }
}
