using System;

namespace _03_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal a = Convert.ToDecimal(Console.ReadLine());
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal c = Convert.ToDecimal(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("equilateral");
                }
                if (a == b || b == c || a == c)
                {
                    Console.WriteLine("isosceles");
                }
                else
                { Console.WriteLine("scalene"); }
            }
            else
            {
                Console.WriteLine("crazy input");
            }

        }
          
    }
}
