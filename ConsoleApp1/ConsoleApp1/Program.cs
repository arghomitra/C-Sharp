


using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "ABCDEFGHI";
            foreach (var c in str)
            {
                Console.WriteLine((int)c);
            }

        }
    }
}
