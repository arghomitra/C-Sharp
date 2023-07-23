using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int year = Convert.ToInt32(Console.ReadLine());

            for (int i = year + 1; i <= year + 4; i++)
            {
                int sum = i % 4;
                int sum2 = i % 100;
                if (sum == 0)
                {
                    Console.WriteLine(i);
                }


                else if (sum2 == 0)
                {
                    int sum3 = i % 400;
                    if (sum3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            

            }
            */
            int num1 = 6;   
            int num2 = 12;
            for (int i = 2; i <= num1; i++)
            {
                if (num1%i==0 && num2%i ==0)
                {

                }
            }
        }
    }
}
