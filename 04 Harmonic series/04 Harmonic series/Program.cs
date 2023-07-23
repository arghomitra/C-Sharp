using System;


namespace harmonic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            double tamp = 0;
            Console.Write($"1");

            if (num > 0)
            {
                for (double i = 2; i <= num; i++)
                {

                    Console.Write($" + 1/{i}");

                    double a = 1 / i;
                    double sum = a + tamp;
                    tamp = sum;

                }

                double result = 1 + tamp;
                Console.WriteLine("\n" + "sum = " + result.ToString("N4"));
            }
        }
    }
}
