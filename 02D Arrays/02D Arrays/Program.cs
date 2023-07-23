using System;
using System.Runtime.ExceptionServices;
using System.Linq;

namespace _02D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[2, 10];
            int[,] scores =
            {
                {18, 19,20,10,15,8},
                {10,12,13,8,9,2 }
            };
            //Console.WriteLine(array2[0,3]);
            //Console.WriteLine(array2[row,colum]);

            double[] total = new double[6];
            //total = (0.3*first row) + (0.7* second row)
            for (int i = 0; i < total.Length; i++)
            {
                total[i] = (0.3 * scores[0,i] + (0.7 * scores[1,i]));
            }
            Console.WriteLine(total);
            Console.WriteLine(total.Average());
        }
    }
}
