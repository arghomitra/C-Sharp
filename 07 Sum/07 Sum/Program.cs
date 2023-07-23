

using System;

namespace _07_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                {
                    int temp = 0;
                    int start = 1;
                    for (int i = 1; i < num; i++)
                    {
                        temp = temp + (start * start);
                        start++;

                    }
                    Console.WriteLine(temp);
                }

                else if (num < 0)
                {
                    int temp = 0;
                    int start = num + 1;
                    for (int i = 0; i < num * (-1); i++)
                    {
                        temp = temp + (start * start);
                        start++;

                    }
                    Console.WriteLine(temp);
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("converting problem"); ;
            } catch (OverflowException)
            {

                Console.WriteLine("too big for this type"); ;
            } catch (Exception)
            {

                Console.WriteLine("crazy input"); ;
            }

            
            
        }
    }
}
