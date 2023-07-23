using System;
using System.Globalization;

namespace Class_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             //multiplication 
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <11 ; i++)
            {
                int result = i * num;
                Console.WriteLine($" {num} * {i} = {result}");
            }


            //multiplication reverse
            int num2 = Convert.ToInt32(Console.ReadLine());
            for (int j = 10;  j>0; j--)
            {
                int result2 = j * num2;
                Console.WriteLine($" {num2} * {j} = {result2}");

            }
             
             */


            for (int i = 1; i <10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("* ");//use write for print same line
                }
                Console.WriteLine();
            }

        }
    }
}
