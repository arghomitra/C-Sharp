using System;
using System.Collections.Generic;

namespace dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //int[] myArray = { 2, 5, 10 };
            //List<int> myList = new List<int>();
            Dictionary<string,int> mydict = new Dictionary<string,int>();

            //myList.Add(10);
            mydict.Add("Tristian", 10);
            mydict.Add("colin", 18);
            mydict.Add("glory", 17);
            /*
            foreach (var box in myArray)
            {
                Console.WriteLine(box); 
            }
             */
            foreach (var item in mydict)
            {
                Console.WriteLine($"{item.Key} scord {item.Value} in exam");
            }
        }
    }
}
