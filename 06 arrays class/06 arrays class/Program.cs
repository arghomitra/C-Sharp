using System;

namespace _06_arrays_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //regular variable
            //int myvariable1;
            //int myvariable2 = 1;

            //array of variable(int):version 1
            int[] myArray = new int[5];
            int[] myArray2 = { };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(myArray2[i]);
            }

            //string[] namesarray = new string[5];
            //int[] scoresArray ={10, 2, 3, 4, 5 };
            //namesarray[0] = "ARGHO";
            //for (int i = 0; i < namesarray.Length; i++)
            //{
            //    namesarray[i] = Console.ReadLine();
            //}


            //string names = Console.ReadLine();
            //string[] namesArrays2 = names.Split(" ");
            //Console.WriteLine();
            //int[] score = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum = 0;
            //for (int i = 1; i < score.Length; i++)
            //{
            //    sum=sum+score[i];
            //}   
            //Console.WriteLine(sum/score.Length);


        }
    }
}
