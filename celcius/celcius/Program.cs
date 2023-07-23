using System;

namespace celcius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            decimal num =Convert.ToDecimal(Console.ReadLine());
            decimal kelvin = Convert.ToDecimal(num + 273);
            Console.WriteLine(kelvin.ToString("N3")+ "°K");
            decimal farhenhite = num * 18 / 10 + 32;
            Console.WriteLine(farhenhite.ToString("N3")+ "°F");

        }
    }
}
