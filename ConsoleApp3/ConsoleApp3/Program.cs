using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String inpu = Console.ReadLine();
            string input = inpu.ToLower();
            char[] array = input.ToCharArray();
            foreach (var item in array)
            {
                if (item>='a' && item<='z')
                {
                    Console.WriteLine(item);
                }
                else
                    Console.WriteLine("hggdskl");
            }
        }
    }
}
