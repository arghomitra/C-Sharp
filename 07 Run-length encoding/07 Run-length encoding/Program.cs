using System;
using System.Linq;

namespace _07_Run_length_encoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string word = input + " ";
            String newWord = String.Empty;
            int count = 1;
            bool result = input.All(Char.IsLetter);
            try
            {
                if (result == false)
                {
                    Console.WriteLine("crazy input");
                }
                else
                {
                    for (int i = 0; i < word.Length - 1; i++)
                    {
                        if (word[i] == word[i + 1])
                        {
                            count++;
                        }
                        else
                        {

                            newWord = newWord + count;
                            newWord = newWord + word[i];

                            count = 1;
                        }

                    }
                    string output = newWord.Replace("1", "");
                    Console.WriteLine(output);
                }
                
            }
            catch (FormatException)
            {

                Console.WriteLine("converting problem"); ;
            }
            catch (OverflowException)
            {
                Console.WriteLine("too big for this type");
            }


        }
    }
}
