using System;
using System;
using System.IO;

namespace _07_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
           StreamReader input = File.OpenText("BTS.txt");
            string fullText = input.ReadToEnd();
            input.Close();
            string[] fileArray = fullText.Split(" ");
            for (int i = 0; i < fileArray.Length; i++)
            {
                Console.Write(fileArray[i]);
            }
        }
    }
}
