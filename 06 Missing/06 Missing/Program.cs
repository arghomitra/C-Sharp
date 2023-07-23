using System;


namespace _06_Missing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] number = (Console.ReadLine()).Split(" ");
            int[] numbers = Array.ConvertAll(number, int.Parse);
            
            int max = 0;
            
            
            for (int i = 0; i < number.Length; i++)
            {
                if (numbers[i] > max)
                {
                max= numbers[i];
                }
                
                
            }
            int min = max;

            for (int i = 0; i < number.Length; i++)
            {
                if (numbers[i]<min)
                {
                    min = numbers[i];
                }

            }
            
           
            
            int sum = 0;
            for (int i = min; i <= max; i++)
            {
                sum =sum + i;
             
            }
            

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                count = count + numbers[i];

            }
           

           

            if (sum != count)
            {
                Console.WriteLine(sum - count);
            }
            else
            {
                Console.WriteLine("There is no missing link!");
            }

        }
    }
}
