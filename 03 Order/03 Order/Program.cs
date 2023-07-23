using System;

namespace _03_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a=Convert.ToDouble(Console.ReadLine());
            double b=Convert.ToDouble(Console.ReadLine());
            double c=Convert.ToDouble(Console.ReadLine());
          

            if (a >b && a>c && b>c)
            {
                Console.WriteLine($"{a},{b},{c}");
            }

            else if (b > a && a > c && b>c)
            {
                Console.WriteLine($"{b},{a},{c}");
            }
            else if (c > a & c > b & b > c)
            {
                Console.WriteLine($"{c},{b},{a}");
            }

        }
    }
}
