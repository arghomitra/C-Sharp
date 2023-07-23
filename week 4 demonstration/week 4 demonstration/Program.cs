using System;

namespace _04fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 10;

            int firstNumber = 1;
            int secondNumber = 1;

           
            int temp;

            for (int i = 0; i < length - 2; i++)
            {
                temp = firstNumber + secondNumber;
                
                firstNumber = secondNumber;
                secondNumber = temp;
                if (i ==length-3)
                {
                    Console.WriteLine(temp);    
                }
            }

        }
    }
}