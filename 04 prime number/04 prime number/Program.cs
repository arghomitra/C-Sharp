using System;

namespace _04_prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 1)
            {
                for (int i = 2; i <= n; i++)
                {
                    bool prime = true;
                    int divider = 2;
                    int maxDivider = (int)Math.Sqrt(i);
                    while (divider <= maxDivider)
                    {
                        if (i % divider == 0)
                        {
                            prime = false;
                            break;
                        }
                        divider++;
                    }
                    if (prime)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
