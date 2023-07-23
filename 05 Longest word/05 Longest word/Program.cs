using System;
using System.Diagnostics.Tracing;
using System.IO;
using System.Runtime.CompilerServices;

namespace _05_Longest_word
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fileName = Console.ReadLine();
            StreamReader input =File.OpenText(fileName);
            string fileText = input.ReadToEnd();

            string ConvertSemicolonToSpace =fileText.Trim().Replace(";"," ");

            string[] array = ConvertSemicolonToSpace.Split(" ");

            int a = 0;
            int b = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int length = array[i].Length;

                if (length > a)
                {
                    a= length;
                    b= i;
                }


            }


            Console.WriteLine(array[b]);
        }
    }
}
