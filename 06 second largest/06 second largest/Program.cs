using System;
using System.Globalization;

namespace _06_second_largest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] numbers = "6 2 18 17 18 17 18 15 17 2 4 12 18 18 18".Split(' ');

            string store =string.Empty;
            
            string sortStore =string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!store.Contains(numbers[i]))
                {
                    store = store +" "+ numbers[i];

                    
                }
                
            }
            
            string[] storeArray = store.Split("");

            int[] intStoreArray = Array.ConvertAll(storeArray,int.Parse);
            int start = 0;
            int temp = 0;

            for (int i = 0; i < intStoreArray.Length; i++)
            {
                
                if (intStoreArray[i] > intStoreArray[i+1])
                {
                    temp = intStoreArray[i];
                    intStoreArray[i] = intStoreArray[i + 1];
                    intStoreArray[i + 1] =temp;
                    Console.WriteLine(temp);
                }
            }
            

        }
    }
}
