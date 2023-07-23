using System;

namespace largest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal a, b, c;
            a=Convert.ToDecimal(Console.ReadLine());
            b=Convert.ToDecimal(Console.ReadLine());
                c=Convert.ToDecimal(Console.ReadLine());
             
            if(a>b && a>c)
            {
                Console.WriteLine(a);
                
            }
            else if(b>c && b>a)
                {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
