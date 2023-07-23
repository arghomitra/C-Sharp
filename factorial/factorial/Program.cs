using System;


namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int firstNumber = 1;
            int secondNumber = 1;
            int tamp =0;
            if (length>0)
            {
                for (int i = 0; i < length; i++)
                {
                    tamp = firstNumber * secondNumber;
                    firstNumber = tamp;
                    secondNumber++;
                }
                Console.WriteLine(tamp);
            }
            else
            { Console.WriteLine("crazy input"); }
        }
    }
}
