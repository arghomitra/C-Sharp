using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SumOfDigits
            int input =Convert.ToInt32(Console.ReadLine());
            int num = input;
            int sum = 0;
            int number = input;
            while (num > 9)
            {
                
                sum = 0;
                int devide = 0;
                int remainder = 0;
                while (number != 0)
                {
                    remainder = number % 10;
                    sum = sum + remainder;
                    devide = number / 10;
                    number = devide;
                }
                number = sum;
                num = sum;
            }
            Console.WriteLine(sum);

           
        }
    }
}
