﻿using System;

namespace odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            
            if (number % 2 == 0)
            {
                Console.WriteLine("False");
                
            }
            else
                {
                Console.WriteLine("True");
            }
        }
    }
}
