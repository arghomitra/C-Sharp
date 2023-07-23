using System;

namespace root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * a * c;

            if(D>0)
            {
                double root1 = ((-b + Math.Sqrt(D)) / (2 * a));
                double root2 = (-b - Math.Sqrt(D)) / (2 * a);


                Console.WriteLine($"{(Math.Round(root1, 2))} {(Math.Round(root2, 2))}" ); 

            }
            else if(D==0)
                {
                double root = ((-b + Math.Sqrt(D)) / (2 * a));
                Console.WriteLine(Math.Round(root, 2));

            }
            else if (D<0)
                    { Console.WriteLine("no real solution"); }
        }
    }
}
