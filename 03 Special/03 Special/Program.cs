using System;

namespace _03_Special
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            char charecter = Convert.ToChar(Console.ReadLine());
            int number= Convert.ToInt32(charecter);
            

            if (number >= 48 && number <= 57)
            {
                Console.WriteLine("digit");
            }

            else if (number == 65 || number == 97 || number == 69 || number == 101 || number == 73 || number == 105 || number == 79 || number == 111 || number == 85 || number == 117)
            {
                Console.WriteLine("vowel");
            }

            else if ((number>=0 && number<=47) || (number >= 58 && number <= 64) || (number >= 91 && number <= 96) || (number >= 123 && number <= 127))
            {
                Console.WriteLine("special character");
            }
            else
            {
                Console.WriteLine("consonant");
            }
        }
    }
}
