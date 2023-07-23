using System;


namespace _06_Rotate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(" ");
            int rotateIndex = Convert.ToInt32(Console.ReadLine());

            if (rotateIndex > 0)
            {
            for (int i = rotateIndex ; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");

            }
            for (int i = 0; i < rotateIndex; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
            }

            else if (rotateIndex < 0)
            {
                int length =(inputArray.Length)+rotateIndex;
                for (int i = length; i < inputArray.Length; i++)
                {
                    Console.Write(inputArray[i] + " ");
                }
                for (int i = 0; i < length; i++)
                {
                    Console.Write(inputArray[i] + " ");
                }
            }
            
        }
    }
}
