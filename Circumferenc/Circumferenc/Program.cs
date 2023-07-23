using System;

namespace Circumferenc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length, width, Circumferenc;
            length=Convert.ToInt32(Console.ReadLine());
            width = Convert.ToInt32(Console.ReadLine());
            Circumferenc = 2 * (length + width);
            Console.WriteLine(Circumferenc);

            }
    }
}
