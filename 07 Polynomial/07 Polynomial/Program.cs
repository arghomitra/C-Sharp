using System;
using System.IO;


namespace _07_Polynomial
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                
                string[] numbers = (Console.ReadLine()).Split(' ');

               
                int power = Convert.ToInt32(numbers[0]);
                
                
                double X =( Convert.ToDouble(numbers[1]) )* (-1);
                double result = 1 + X;

                for (int i = 1; i < power; i++)
                {
                    double num = X;
                    for (int j = 0; j < i; j++)
                    {
                        num = num * X;

                    }

                    result = result + num;

                }

                string output = result.ToString("N2");
                output = output.Replace(",", "");


                Console.WriteLine(output);
            }


            
			catch (FormatException)
			{

                Console.WriteLine("converting problem");
			}
            catch (OverflowException)
            {

                Console.WriteLine("too big for this type") ;
            }
            catch (Exception)
            {

                Console.WriteLine("crazy input");
            }
        }
    }
}
