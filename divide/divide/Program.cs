using System;

namespace divide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if((a % b)==0)
            {
                Console.WriteLine("True");

            }
            else
            { Console.WriteLine("False"); }
        }
    }
}
