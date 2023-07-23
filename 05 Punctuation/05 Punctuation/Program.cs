

using System;

namespace _05_Punctuation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result =string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                

                if (  (c >='!' &&  c <= '/') || (c >= ':' && c <= '?') || (c >= '[' && c <= '-') || (c >= '{' && c <= '}'))
                {
                    if (!(input[i - 1] == input[i]))
                    {
                        result = result + c;
                    }
                }
                else
                {
                    result = result + c;
                }
            }
            Console.WriteLine(result);
        }
    }
}
