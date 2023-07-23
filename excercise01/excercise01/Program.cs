using System;
using System.Collections.Generic;
using System.Linq;

namespace excercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string status = "Y";
            List<string> names = new List<string>();
            List<int> PE = new List<int>();
            List<int> EX = new List<int>();

            Console.WriteLine("DO YOU WANT TO ADD A NEW STUDENT?");
            Console.WriteLine("ENTER X TO CALCULATE THE AVARAGE ,ENTER ANYTHING ELSE TO ");


            while (status != "X")
            {
                Console.Write("name :");
                string name = Console.ReadLine();
                Console.Write("permanent evaluatation :");
                int PE_input = Convert.ToInt32(Console.ReadLine());
                Console.Write("Exam :");
                int EX_input = Convert.ToInt32(Console.ReadLine());

                //add to the list
                names.Add(name);
                PE.Add(PE_input);
                EX.Add(EX_input);

                Console.WriteLine("DO YOU WANT TO ADD A NEW STUDENT?");
                Console.WriteLine("ENTER X TO CALCULATE THE AVARAGE ,ENTER ANYTHING ELSE TO ");
                status = Console.ReadLine();

                List<double> total = new List<double>();
                for (int i = 0; i < names.Count; i++)
                {

                    double totalScore = (0.3 * PE[i]) + (0.7 * EX[i]);
                    if ((totalScore>7) && (totalScore<14))
                    {
                        if (EX[i]<6)
                        {
                            total.Add(7);

                        }
                        else if (PE[i]<6)
                        {
                            total.Add(7);
                        }
                        else
                        {
                            total.Add(totalScore);
                        }
                    }
                    else
                    {
                        total.Add(totalScore);
                    }

                   
                }
                Console.WriteLine($"the total of the class is {total.Average()}");

            }
        }
    }
}
