using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _05Reading_class_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              StreamReader input = File.OpenText("Rapunzel.txt");
             string text = input.ToEnd();
             input.Close();
             Console.WriteLine(text);
             */


            /*
             *  LINE BY LINE
             
              StreamReader input = File.OpenText("Rapunzel.txt");
            string line = input.ReadLine();
            while (line != null)
            {

                Console.WriteLine(line);
                line = input.ReadLine();
            }


             
             
             */
            /*
            //CHARECTER BY CHERECTER
            int amount = 0;
            StreamReader input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                char c = (char) input.Read();
                amount++;
                Console.WriteLine(c+" ");
                 
            }

            Console.WriteLine($"Rapunzel has {amount} charecter");

            */


            /*
              //READ IN 10 ,LINES
            StreamReader input = File.OpenText("Rapunzel.txt");
            for (int i = 0; i < 10; i++)            {
                string line = input.ReadLine();
                Console.WriteLine(line);
            }
            input.Close();

             
             */

            /*  StreamReader input = File.OpenText("Rapunzel.txt");
              string text = input.ReadToEnd();    
              input.Close();
              Console.WriteLine(text);

              foreach(char latter in text)
              {
                  Console.WriteLine(latter);
              }
            */

            /*
             * ALL IN UPPERCASE
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            input.Close();
            Console.WriteLine(text.ToUpper());
            */
            //READING IN THE TEXT
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            input.Close();
            Console.WriteLine(text.ToUpper());





            //making pattern
            Regex mypattern = new Regex(@"Rapunzel",RegexOptions.IgnoreCase);

            //MAKING SEARCHING PATTERN
            MatchCollection matches =mypattern.Matches(text);   
            Console.WriteLine($"The word Rapunzel occurs {matches.Count} times.");
        }
    }
}
