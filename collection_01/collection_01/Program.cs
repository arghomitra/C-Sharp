
using System;
using System.Collections.Generic;

namespace collection_01
{
    internal class Program
    {
        static void Main(string[] args)
        {   //ARRAYS
            int[] myArray1 = { 12, 8, 10 };
            int[] myArray2 = new int[3];

            // myArray1[3] = 9; \\
            //Console.WriteLine(myArray1[3]); \\

            //list
            List<string> myList = new List<string>();
            myList.Add("tristan");
            myList.Add("colin");
            myList.Insert(1, "glory");
            //Console.WriteLine(myList[0]);
            foreach (string element in myList)
            {
                Console.WriteLine(element);
            }



        }
    }
}
