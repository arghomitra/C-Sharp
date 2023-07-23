using System;

namespace avarage
/*
 02 Average
Read in four numbers and calculate the average. Print average as an integer.
Problems with . as the decimal separator? Add this line of code in your Main-method before you start reading input from the console:
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
Input/Output
input:
23
78
10
10.6
output:
30
input:
13.6
8
-10
7
output:
4
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            decimal a, b, c, d;
               a = Convert.ToDecimal (Console.ReadLine());
            b = Convert.ToDecimal (Console.ReadLine());
            c = Convert.ToDecimal (Console.ReadLine());
            d = Convert.ToDecimal (Console.ReadLine());
            

            
            int result = decimal.ToInt32((a + b + c + d) / 4);
            
            Console.WriteLine(result);

        }
    }
}

