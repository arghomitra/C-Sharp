using System;

namespace _03_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ascii;
            
            ascii = Console.Read();
            if (ascii >= 65 && ascii <= 90)
            {
                Console.WriteLine("uppercase");
            }
            else if (ascii >= 97 && ascii <= 122)
            {
                Console.WriteLine("lowercase");
            }
            else
            { Console.WriteLine("crazy input"); }
        }
    }
}
