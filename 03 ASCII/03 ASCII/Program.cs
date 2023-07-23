using System;
using System.IO;

namespace _03_ASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num=Convert.ToInt32(Console.ReadLine());
            char charecter=Convert.ToChar(num);
            

            if ( num >=0 && num <= 64)
            {
                Console.WriteLine('A');
            }
            else if (num>=91 && num<=93)
            {
                Console.WriteLine('Z');
            }
            else if (num >= 94 && num <= 96)
            {
                Console.WriteLine('a');
            }
            else if (num >= 123 && num <= 127)
            {
                Console.WriteLine('z');
            }
            else 
            { Console.WriteLine(charecter); 
            }
           
        }
    }
}
