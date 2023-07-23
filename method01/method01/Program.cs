using System;

namespace method01
{
    internal class Program
    {
        int[] myArray = { 1, 2, 3 };
        static void Print(int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);

            }
        }
    
        static void Main(string[] args)
        {
        
            Print(3);
            /*
            //printing a array
        //this is the array i want to print
            int[] myArray = { 1, 2, 3, 4, 5, 6};

            //now i will print it
            //each element in  a NEW LINE
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            int[] myArray2 = { 0, 0, 0, 0 };
            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.WriteLine(myArray2[i]);
            }
            */
//            Console.Write("REVERSE ARRAY ");

//            int[] numberArray = { 1, 2, 3 };
//            int store = numberArray[0];
//            for (int i = numberArray.Length - 1; i >= 0; i--)
//            {
//                Console.Write(numberArray[i] + " ");
//            }
//            for (int i = 0; i < numberArray.Length; i++)
//            {
//                if (store < numberArray[i])
//                {
//store = numberArray[i];
//                }
//            }
//            Console.WriteLine("HIGHEST NUMBER "+store);
//static void Reverse(int[] inpuyArray)

//            static int[] inputIntArray()
//            {
//                Console.Write("enter array : ");
//            }


//            static void main(string[] args)
//            {
//                Console.WriteLine("which question do you want to execute? ");
//                string question = Console.ReadLine();

//                switch (question)
//                {
//                    case "A":
//                        Console.WriteLine("executeing question A : reverse");
//                        int[] inputArrayReverse = InputIntArray();
//                        Reverse(inputArrayReverse);
//                        break;
//                    case "B":
//                        Console.WriteLine("executeing question B : hiest");
//                        int[] inputArrayHieght = InputIntArray();
//                        Reverse(inputArrayHeight);
//                        break;
//                        default: Console.WriteLine("note found");
//                        break;
//                }
//            }

              
        }
    }
}
