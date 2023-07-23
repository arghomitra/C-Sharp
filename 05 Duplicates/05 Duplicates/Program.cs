using System;

namespace _05_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;
            string pancuation = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (!result.Contains(c))
                {
                    result += c;
                }
            }
            Console.WriteLine(result);
        }
    }
}
