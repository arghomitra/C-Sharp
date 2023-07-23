using System;

namespace decimal_part
{
    internal class Program
    {
        static void Main(string[] args)
        {
           decimal num=Convert.ToDecimal(Console.ReadLine());
            int number=decimal.ToInt32(num);
            decimal result =Convert.ToDecimal(num-number);
            Console.WriteLine("Decimal part = " + result.ToString("N6"));
        }
    }
}
