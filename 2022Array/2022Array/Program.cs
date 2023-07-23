using System;

namespace _2022Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("enter the student grades : ");

            // string[] answers = (Console.ReadLine()).Split(' ');


            /*
             * sorting numbers
            string[] numbers = (Console.ReadLine()).Split(' ');

            Array.Sort(numbers);

            foreach (var n in numbers)
            {
                Console.WriteLine(n + " " );
            }
            */
            /*
             * sorting double numbers
                        string[] numbers = (Console.ReadLine()).Split(' ');

                        double[] doubleNumbers = Array.ConvertAll(numbers, double.Parse);

                        Array.Sort(doubleNumbers);

                        foreach (var n in doubleNumbers)
                        {
                            Console.WriteLine(n + " ");
                        }
                        */

            /*
             * sum of all numbers in a array ny (foreach)
            string[] numbers = Console.ReadLine().Split(' ');
            int[] number = Array.ConvertAll(numbers, int.Parse);
            int num = 0;
            foreach (int  n in number)
            {
                num += n;
            }
            Console.WriteLine(num);
            */

            
             //  sum of all numbers in a array ny (for)
            string[] numbers = Console.ReadLine().Split(" ");
            int[] number = Array.ConvertAll(numbers, int.Parse);
            int num = 0;
            for (int i = 0; i < number.Length; i++)
            {
                num += number[i];
                
            }
            Console.WriteLine(num);
            

            /*
            string number = "1 2 3 4 5 6" ;
            char [] charArray = new char[number.Length];
            
            foreach (var item in number)
            {
                Console.Write(item);
            }*/
            /*
            string[] array = Console.ReadLine().Split(" ");
            string[] reversed = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversed[array.Length - i - 1] = array[i];
            }


            for (int i = 0; i < reversed.Length; i++)
            {
                Console.Write(reversed[i] + " ");
            }

            */


































        }
    }
}
