using System;

namespace curzon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int number;
            bool success = int.TryParse(num, out number);
            
                if (success) 
            {


                if (number >= 0)
                {

                    double a = Convert.ToInt32(Math.Pow(2, number) + 1);
                    double b = Convert.ToInt32((2 * number) + 1);

                    if (a % b == 0)
                        Console.WriteLine("True");
                    else
                        Console.WriteLine("False");
                }
                else
                    Console.WriteLine("crazy input");

            }
            
            else
                Console.WriteLine("crazy input");
        }
    }
}