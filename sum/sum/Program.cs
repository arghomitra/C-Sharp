using System;
namespace sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            decimal a, b, c, sum;
            a = Convert.ToDecimal(Console.ReadLine());
            b = Convert.ToDecimal(Console.ReadLine());
            c = Convert.ToDecimal(Console.ReadLine());
           
            sum = a + b + c;
            int integerSum =Decimal.ToInt32(sum);
            Console.WriteLine(integerSum);
        }
    }
}