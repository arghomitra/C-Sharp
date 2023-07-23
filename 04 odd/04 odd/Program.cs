using System;

namespace May_the_odds



{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int firstNumber = 1;
            int temp = 1;

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    int remainder = i % 2;
                    if (remainder != 0)
                    {
                        temp = i * firstNumber;
                        firstNumber = temp;
                    }
                }
                Console.WriteLine(temp);
            }

            else if (a > b)
            {
                for (int i = b; i <= a; i++)
                {
                    int remainder = i % 2;
                    if (remainder != 0)
                    {
                        temp = i * firstNumber;
                        firstNumber = temp;
                    }
                }
                Console.WriteLine(temp);

            }
        }
    }
}