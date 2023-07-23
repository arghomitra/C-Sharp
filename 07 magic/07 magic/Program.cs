using System;
using System.Data;
using System.Linq.Expressions;

namespace _07_magic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = string.Empty;
            int input =Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                 numbers =numbers+ Console.ReadLine()+" ";
                
               
            }
           numbers = numbers.Trim();
            
            string[] arrayNumber = numbers.Split(" ");

            int colum = arrayNumber.Length / input;

            int[,] DDarray = new int[input, colum];
            int index = 0;
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    DDarray[i, j] =int.Parse( arrayNumber[index]);
                    index++;

                }
            }
            Console.WriteLine(DDarray[0, 0] + DDarray[1,0]);
            Console.WriteLine(DDarray[0, 1] + DDarray[1, 1]);
            

        }
    }
}
