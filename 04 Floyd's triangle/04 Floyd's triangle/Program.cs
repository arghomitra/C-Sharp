using System;
class Program
{
    static void Main(string[] args)
    {

        int i, j, k = 1;
        int num = Convert.ToInt32(Console.ReadLine());
        for (
            
            i = 1; i <= num; i++)
        {
            for (j = 1; j < i + 1; j++)
            {
                Console.Write(k++ + " ");
            }

            Console.Write("\n");
        }
    }
}