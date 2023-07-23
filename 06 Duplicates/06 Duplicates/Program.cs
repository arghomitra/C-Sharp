using System;

namespace _06_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            string[] array = input.Split(" ");
            string result = string.Empty;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (!result.Contains(array[i]))
                {
                    result = result + " " + array[i];
                }
                else
                {
                    count++;
                }
            }
            
            Console.WriteLine(count);
        }
    }
}
