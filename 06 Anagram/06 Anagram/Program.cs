
using System;


namespace _06_Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 =Console.ReadLine();
            string input2 =Console.ReadLine();
            string word1 =input1.ToLower();
            string word2 =input2.ToLower(); 

            int count = 0;

            for (int i = 0; i < word1.Length; i++)
            {
                if (word2.Contains(word1[i]))
                {
                    count++;
                }
            }
            if ((count == word1.Length) || (count == word2.Length))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
