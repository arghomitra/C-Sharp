using System;

namespace for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int length = Convert.ToInt32(Console.ReadLine());
            int firstNumber = 1;
            int secondNumber = 1;
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            int temp;
            for (int i = 0; i < length-2; i++)
            {
                temp=firstNumber+secondNumber;
                Console.WriteLine(temp);
                
                firstNumber=secondNumber;
                secondNumber=temp;
                while (i==length)
                { Console.WriteLine("done");
                    Console.ReadLine();
                }
            }
        }
    }
}
