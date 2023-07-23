using System;

namespace _06_week_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10 students
            int amountsStudents = 10;
            int sum = 0;
            int score = 0;
            int avg ;

            for(int i = 0; i < amountsStudents; i++)
            {
                score = Convert.ToInt32(Console.ReadLine());
                sum += score;

            }
            avg=sum / amountsStudents;
            Console.WriteLine(avg);
        }
    }
}
