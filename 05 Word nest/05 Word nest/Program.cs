
using System;

namespace _05_Word_nest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "code";
            string wordnest = "cocodccococodededeodeede";
            int count = 0;

           while (wordnest.Length != word.Length)
            {
                wordnest = wordnest.Replace(word, "");
                Console.WriteLine(wordnest);
                count++;

            }
            Console.WriteLine(count);


            /*
             * NOT SO PERFECT WORDNEST
            while (wordnest.Contains(word))
            {
                wordnest = wordnest.Replace(word, "");
                Console.WriteLine(wordnest);
                count++;

            }
            Console.WriteLine(count);
            */
        }
    }
}
