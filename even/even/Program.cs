using System;

namespace even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if (a % 2 == 0)
            {
                if (b % 2 == 0)
                {
                    if (c % 2 == 0)
                    { Console.WriteLine(a + b + c); }
                    else
                    { Console.WriteLine(a + b); }
                }
                else if (c % 2 == 0)
                {
                    Console.WriteLine(a + c);
                }
                else
                {
                    Console.WriteLine(a);
                }
            }

            else if (b % 2 == 0)
            {
                if (c % 2 == 0)
                {

                    Console.WriteLine(c + b);
                }
                else
                    Console.WriteLine(b);
            }
            else
            { Console.WriteLine(c); }
        }
    }
}