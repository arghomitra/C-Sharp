using System;

namespace method
{
    internal class Program
    {
        static void quection1()
        {
            Console.WriteLine("quection1()");
        }
        static void quection2()
        {
            Console.WriteLine("quection2()");
        }
        static void Main(string[] args)
        {
            string quection = Console.ReadLine();

            switch (quection)
            {
                case "1":
                    quection1();
                        break;

                    case "2":
                    quection2();
                    break;
                
            }
        }
    }
}
