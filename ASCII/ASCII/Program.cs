using System;

namespace ASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nu = Convert.ToInt32(Console.ReadLine());
            char num = Convert.ToChar(nu);
            string charecter = Convert.ToString(num);
            Console.WriteLine(charecter.ToLower());
            Console.WriteLine(charecter.ToUpper());
        }
    }
}
