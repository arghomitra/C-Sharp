using System;


namespace _05_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            String input = Console.ReadLine();
            string inputLower = input.ToLower();

            string vowels = string.Empty;
            string consonants = string.Empty;
            string digits = string.Empty;
            string other = string.Empty;

           
            for (int i = 0; i < input.Length; i++)
            {
                char c = inputLower[i];
                int ascii =Convert.ToInt32(c);

                if (c=='a' || c == 'e' || c == 'i' || c == 'o' || c =='u'  )
                {
                    vowels += c;
                }

                else if(ascii >=0 && ascii <= 47 && ascii != 32)
                {
                    char others =Convert.ToChar(ascii);
                    other += others;
                }

                else if (ascii >= 48 && ascii <= 57)
                {
                    char digit = Convert.ToChar(ascii);
                    digits += digit;
                }
                else if(c != ' ')
                {
                    consonants += c;
                }
            }
            int vowelsLength = vowels.Length;
            int consonantsLength = consonants.Length;
            int digitsLength = digits.Length;
            int otherLength = other.Length;


            Console.WriteLine("consonants: " + consonantsLength);
            Console.WriteLine("vowels: "+ vowelsLength);
            Console.WriteLine("digits: " + digitsLength);
            Console.WriteLine("other: " + otherLength);
        }
    }
}
