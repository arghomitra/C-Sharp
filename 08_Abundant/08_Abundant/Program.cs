using System;

namespace _08_Abundant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            for (int i = int.Parse(input[0]); i <= int.Parse(input[1]); i++)
            {
                int sum = 0;
                int calculation = 0;

                for (int j = 1; j < i; j++)
                {
                    calculation = i % j;

                    if (calculation == 0)
                    {
                        sum += j;
                    }
                }
                if (sum > i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
