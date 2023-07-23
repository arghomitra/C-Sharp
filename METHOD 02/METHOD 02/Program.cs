
using System;

namespace METHOD_02
{
    internal class Program
    {

        static int[] add(int[]array)

        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1;

            }
            Console.WriteLine(array);
        }
        static void Main(string[] args)
        {
            
        }
       
    }
}
