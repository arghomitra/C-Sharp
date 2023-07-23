using System;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            int num = 1344;

            string text = num.ToString();
            string khali = string.Empty;
            string[] strArray =  new string[text.Length];

            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] = text[i].ToString();
            }

            int[] intArray = Array.ConvertAll(strArray, int.Parse); //int Array

            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }*/

            /*

            string input = "Never odd or even";//Console.ReadLine();
            string text = input.Replace(" ", "");
            Console.WriteLine(input.Length);
            Console.WriteLine(text.Length);
            int length = text.Length/2;

            string[] strArray = new string[text.Length];
            string newstring = string.Empty;
                for (int j = text.Length-1; j >0; j--)
                {
                newstring = newstring + strArray[j];
                Console.WriteLine(strArray[j].ToString());
                   
                }
            */
            /* string[] words = Console.ReadLine().Split(",");



             string word1 = words[0].Replace(" ", "");
             string[] word1Array = new string[word1.Length];
             string newText1 = string.Empty;
             for (int i = 0; i < word1Array.Length; i++)
             {
                 word1Array[i] = word1[i].ToString();
             }
            Array.Sort(word1Array);
             for (int i = 0; i < word1Array.Length; i++)
             {
                 newText1 = newText1+ word1Array[i];
             }



             string word2 = words[1].Replace(" ", "");
             string[] word2Array = new string[word2.Length];
             string newText2 = string.Empty;
             for (int i = 0; i < word2Array.Length; i++)
             {
                 word2Array[i] = word2[i].ToString();
             }
             Array.Sort(word2Array);
             for (int i = 0; i < word2Array.Length; i++)
             {
                 newText2 = newText2 + word2Array[i];
             }

             if (newText1 == newText2)
             {
                 Console.WriteLine("True");
             }
             else
             {
                 Console.WriteLine("False");
             }
            */

            string word1 = "listen";
            string[] word1Array = new string[word1.Length];
            for (int i = 0; i < word1Array.Length; i++)
            {
                word1Array[i] = word1[i].ToString();
            }
            foreach (var item in word1Array)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
