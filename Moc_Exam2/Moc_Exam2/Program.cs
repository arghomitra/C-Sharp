/*using System;

namespace Moc_Exam2
{
    internal class Program
    {
        static void quectionA()
        {
            Console.WriteLine("hello");
        }
        static void quectionB()
        {
            Console.WriteLine("hello");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string a = Console.ReadLine().ToLower();
            switch (a)
            {
                case "a":
                    quectionA();
                        break;
                case "b":
                    quectionB();
                    break;
            }
        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld
{
    class Program
    {

        static void Methode1(string a)
        {
            Console.WriteLine("METHODE 1 - input string " + a);
        }

        static void Methode2(int a)
        {
            Console.WriteLine("METHODE 2 - input integer " + a);
        }

        static void Methode3(string a)
        {
            Console.WriteLine("METHODE 3 - input string " + a);
        }

        static void Main(string[] args)
        {
            string methode = Console.ReadLine();

            switch (methode)
            {
                case "1":
                    string input = Console.ReadLine();
                    Methode1(input);
                    break;
                case "2":
                    int i = Convert.ToInt32(Console.ReadLine());
                    Methode2(i);
                    break;
                case "3":
                    input = Console.ReadLine();
                    Methode3(input);
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            Console.ReadLine();
        }
    }
}
