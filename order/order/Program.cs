using System;

namespace order
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if (a>b && a>c)
            {
                if (b>c)
                { Console.WriteLine($"{a} {b} {c}"); }
                else
                { Console.WriteLine($"{a} {c} {b}"); }
            }

            else if (b > a && b > c)
            {
                if (a > c)
                { Console.WriteLine($"{b} {a} {c}"); }
                else
                { Console.WriteLine($"{b} {c} {a}"); }
            }

            else if (c > b && c > a)
            {
                if (b > a)
                { Console.WriteLine($"{c} {b} {a}"); }
                else
                { Console.WriteLine($"{c} {a} {b}"); }
            }
        }
    }
}
