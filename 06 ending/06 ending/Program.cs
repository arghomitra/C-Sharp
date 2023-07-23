using System;
using System.Text;

namespace _06_ending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            
            string newWord = string.Empty;

            string firstWord = words[0];
            string secondWord = words[1];
            
            for (int i = firstWord.Length-1; i > 0; i--)
            {
                for (int j = secondWord.Length-1; j > 0; j--)
                {
                    if (firstWord[i] == secondWord[j]) 
                    {
                        newWord =newWord+firstWord[i];
                        i--;
                    }
                    else
                    {
                        break;
                    }

                }
                break;

            }
            for (int i = newWord.Length-1; i >= 0; i--)
            {
                Console.Write(newWord[i]);
            }
 
        }
    }
}
