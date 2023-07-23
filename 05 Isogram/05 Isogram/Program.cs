
using System;

namespace _05_Isogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string inputLower = input.ToLower();
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char c = inputLower[i];
                if (!result.Contains(c))
                {
                    result += c;
                }
                
            }
            if (result == inputLower)
                {
                Console.WriteLine("True");
            }
            else if (result != inputLower)
            {
                Console.WriteLine("False");
            }

        }
    }
}
