using System;
using System.Linq;

namespace in_the_mix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            string value2 = Console.ReadLine();


            if (value.Length >= value2.Length)
            {
                for (int i = 0; i < value.Length; i++)

                {

                    Console.Write(value.ElementAt(i));

                    for (int j = i; j < value2.Length; j++)
                    {

                        Console.Write(value2.ElementAt(j));
                        break;


                    }
                }


            }
            else
            {
                for (int i = 0; i < value2.Length; i++)

                {

                    Console.Write(value2.ElementAt(i));

                    for (int j = i; j < value.Length; j++)
                    {

                        Console.Write(value.ElementAt(j));
                        break;


                    }
                }
            }
        }
    }
}
