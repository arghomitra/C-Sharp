
using System;

namespace _06_insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberes = Console.ReadLine();
            string Value = Console.ReadLine();

            string combindNumbers = numberes + " " + Value;

            string[] numberArray = combindNumbers.Split(" "); 

            int[] intArray = Array.ConvertAll(numberArray, int.Parse);

            int temp = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i]+" ");
            }
            
        }
    }
}
