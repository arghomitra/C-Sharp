using System;

namespace _06_flip
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string firstInput = Console.ReadLine();
           string store =firstInput;
            for (int i = 1; i < firstInput.Length; i++)
            {
                string secondInput = Console.ReadLine();
                store = store+" "+secondInput;
            }

            string[] storeArray = store.Split(" ");

            for (int i = storeArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(storeArray[i]);
            }
        }
    }
}
