using System;

namespace _04_Next_Fibonaccia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int length = Convert.ToInt32(Console.ReadLine());
            int firstnumber = 1;
            int secondnumber = 1;
            int temp = 0; 


            for (int i = 0; i < length; i++)
            {
                temp = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = temp;
                if (temp == length)
                { Console.WriteLine(temp + firstnumber); }
            }


        }
    }
}
