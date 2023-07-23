using System;
using System.Text;

namespace array_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int variable = 1;
            //int[] array = new int[5];
            //int[] array2 = { 1,5,6,4,2};

            //int[] ages = new int[6];

            //ages[1] = 10;
            //ages[1] = 11;
            //Console.WriteLine(ages[0] + " " + ages[1] + " " + ages[2]);


            //string[] names = { "argho", "asif", "sadman", "sifat" };
            //Console.WriteLine(names.Length);
            //Console.WriteLine(names[0]+" " + names[2]);
            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }*/
            /*
            foreach(string item in names)
            {
                Console.WriteLine(item);
            }*/
            /*
            int number =Convert.ToInt32(Console.ReadLine());

            double[] points =new double[number];

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
                points[i] = Convert.ToDouble(Console.ReadLine());   
            }
            */

            // Console.WriteLine("Enter all names (separate by comma): ");
            //string[] names = (Console.ReadLine()).Split(",");
            // Console.WriteLine("number of names: "+ names.Length);
            

            string[] grades =(Console.ReadLine().Split(' '));
            double[] points = new double[grades.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                points[i] = Convert.ToDouble(grades[i]);

            }


        }
    }
}
