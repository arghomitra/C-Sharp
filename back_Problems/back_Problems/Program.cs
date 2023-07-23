using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace back_Problems
{
    internal class Program
    {
        int sum = 1;
        static void Main(string[] args)
        {/*
           StreamReader input = File.OpenText("BTS.txt");
            string file = input.ReadToEnd().ToLower();
            input.Close();
            //Console.WriteLine(file);

            Regex pattern = new Regex(@"\b\w{8}\b");
            MatchCollection matches = pattern.Matches(file);
            string store = string.Empty;
            foreach (var item in matches)
            {
                if (!store.Contains(item.ToString()))
                {
                    store += item.ToString()+" ";
                }

            }
            Console.WriteLine(store);
            */
            
            /*
            /*
            StreamReader input = File.OpenText("BTS.txt");
            string file = input.ReadToEnd(); 
            input.Close();

            Regex pattern = new Regex(@"[A-z]\w+");
            MatchCollection matches = pattern.Matches(file);

            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }

            */
            /*
            string main = "aghor";
            

            string name = "arrghhmo";
            char[] nameArray = name.ToCharArray();

            int count = 0;
            for (int i = 0; i < nameArray.Length;)
            {
               
                if (main.Contains(nameArray[i]))
                {
                  count++;

                }
               
                   
            }

            Console.WriteLine(count);
            */



            /*
            int number = 16;
            string divider = string.Empty;
            string divition = string.Empty;

            for (int i = 9; i > 1; i--)
            {
                if (number%i==0)
                {
                    divider = i.ToString();
                    divition = (number / i).ToString();
                }
            }
            Console.WriteLine(divider+divition);
            */
            /*
            List<string> myList = new List<string>();
            myList.Add("ldkl");
            //myList.Add("5");
            //myList.Add("ARGHO");
            //myList.Add("AR");
            //myList.Add("ARsffh");
            //myList.Add("GHO");
            //myList.Insert(0, "100");
            //myList.Remove("ARGHO");
            //myList.RemoveAt(0);
            
            Console.WriteLine(myList.IndexOf("ldkl"));
            

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}
