using System;

namespace _12Dec_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string question;
            question = Console.ReadLine();
            switch (question)
            {


                case "A":

                    Console.WriteLine("Execute question A: guess the number game");
                    int hiddenNumber = 7;

                    int guessedNumber = Convert.ToInt32(Console.ReadLine());

                    while (guessedNumber 1 = hiddenNumber)

                        Console.WriteLine("Wrong, try again!"); 
                    guessedNumber = Convert.ToInt32(Console.ReadLine());

                    Console WriteLine("Correct, you won!");

                    break;

                case "B":

                    Console WriteLine("Execute question B"); // reading in the array

                    string[] inputArray = Console.ReadLine().Split(" ");
                    int[] inputInts = Array ConvertAll(inputArray, int Parse);

                    // reading in the number int rotateNumber = Convert.ToInt32(Console.ReadLine());

                    // rotating the array int[] outputInts = new int[inputInts. Length]; for (int i=0; i<)

                    break;
                case "C":

                    Console.WriteLine("Execute question C");

                    break;
                default:

                    Console.WriteLine("crazy input");

                    
            }
        }
    }
}
