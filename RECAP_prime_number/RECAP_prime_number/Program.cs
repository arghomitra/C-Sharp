
using System;

namespace RECAP_prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input < 2)
            {
                Console.WriteLine("crazy input");
            }

            else
            {
                for (int i = 2; i <= input; i++)
                {
                    bool isPrime = true;

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime)
                    {
                        Console.Write($"{i} ");
                    }
                }

            }
        }
    }
}
