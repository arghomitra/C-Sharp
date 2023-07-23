using System;

namespace _04_Sequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstAlphabet = Convert.ToChar(Console.ReadLine());
            char secondAlphabet = Convert.ToChar(Console.ReadLine());


            if (firstAlphabet < secondAlphabet)
            {
                for (char i = firstAlphabet; i <= secondAlphabet; i++)
                {
                    if (i >= firstAlphabet && i != 65 && i != 97 && i != 69 && i != 101 && i != 73 && i != 105 && i != 79 && i != 111 && i != 85 && i != 117)
                    {
                        Console.Write(i);

                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
