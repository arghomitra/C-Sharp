
using System;
using System.Linq;

namespace _07_Caesar
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                int number = Convert.ToInt32(Console.ReadLine());

                string input = Console.ReadLine();
                string inputLower = input.ToLower();
                bool boolResult = input.All(Char.IsLetter);
                if (boolResult == false)
                {
                    Console.WriteLine("crazy input");
                }
                else
                {

                    char[] charArray = inputLower.ToCharArray();

                    if (number <= 26 && number >= 1)
                    {



                        foreach (var item in charArray)
                        {

                            int asccii = Convert.ToInt32(item);
                            int final = asccii + number;

                            if (final >= 97 && final <= 122)
                            {
                                char result = char.ToUpper(Convert.ToChar(final));
                                Console.Write(result);
                            }
                            if (final <= 96)
                            {
                                int newfinal = final + 26;
                                char result = char.ToUpper(Convert.ToChar(newfinal));
                                Console.Write(result);
                            }


                        }





                    }
                    else if (number > 26 || number < -26)
                    {
                        if (number > 26)
                        {
                            int newNumber = number - 26;
                            foreach (var item in charArray)
                            {
                                int asccii = Convert.ToInt32(item);
                                int final = asccii + newNumber;

                                if (final >= 97 && final <= 122)
                                {
                                    char result = char.ToUpper(Convert.ToChar(final));
                                    Console.Write(result);
                                }
                                if (final <= 96)
                                {
                                    int newfinal = final + 26;
                                    char result = char.ToUpper(Convert.ToChar(newfinal));
                                    Console.Write(result);
                                }


                            }

                        }

                        if (number < 26)
                        {
                            int newNumber = number + 26;
                            foreach (var item in charArray)
                            {
                                int asccii = Convert.ToInt32(item);
                                int final = asccii + newNumber;

                                if (final >= 97 && final <= 122)
                                {
                                    char result = char.ToUpper(Convert.ToChar(final));
                                    Console.Write(result);
                                }
                                if (final <= 96)
                                {
                                    int newfinal = final + 26;
                                    char result = char.ToUpper(Convert.ToChar(newfinal));
                                    Console.Write(result);
                                }


                            }

                        }






                    }
                }
            }
			catch (FormatException)
			{

				Console.WriteLine("converting problem");
			}
            catch (OverflowException)
            {

                Console.WriteLine("too big for this type");
            }
        }
    }
}
