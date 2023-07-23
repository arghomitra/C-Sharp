using System;


namespace O6_week_flip
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string firstInput = Console.ReadLine();
            String store =firstInput;

            for (int i = 1; i < firstInput.Length; i++)
            {
                string secondInput = Console.ReadLine();
                store = store+" "+secondInput;
            }

            String[] storeArray = store.Split(" ");

            for (int i =storeArray.Length-1 ; i >= 0 ; i--)
            {
                Console.WriteLine(storeArray[i]);
            }
        }
    }
}
