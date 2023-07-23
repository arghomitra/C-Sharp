using System;

namespace _02_Radius
{
    internal class Program


    /*02 Radius

Read in the area of a circle, and calculate the radius using this formula  r = √(A / π). Round the radius to 2 digits. (tip: use Math-library)

Problems with . as the decimal separator? Add this line of code in your Main-method before you start reading input from the console:
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");



Input/Output
input:
10
output:
1.78

input:
12.566
output:
2.00*/
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            double A = Convert.ToDouble(Console.ReadLine());
            double R = A/Math.PI;
            double r=Math.Sqrt(R);
            double result = Math.Round(r,2);
            
            Console.WriteLine(result.ToString("N2"));
        }
    }
}
