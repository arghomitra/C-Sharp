using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace latest
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            StreamReader input = File.OpenText("Beyonce.txt");
            string allText = input.ReadToEnd().Replace(";", " ").ToLower();
            input.Close();



            Regex pattern = new Regex(@"[a-z]\w+");
            MatchCollection match = pattern.Matches(allText);
            string onlyWord = string.Empty;
            String result = String.Empty;
            foreach (var word in match)
            {

                //onlyWord += word.ToString()+" ";
                int sum = 0;
                

                foreach (char charecter in word.ToString())
                {

                    sum += (int)charecter - 96;
                }

                if (sum == 200 && !result.Contains(word.ToString()))
                {
                    result += word.ToString() + " ";
                    
                }


            }
            Console.WriteLine(result);
            */
            try
            {
                string[] input = Console.ReadLine().Split(' ');
                bool condition = false;
                string store = string.Empty;
                foreach (string number in input)
                {
                    //int intNumber = int.Parse(number);



                    char letter = 'A';
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= 5; j++)
                        {
                            if (number == (i.ToString() + j.ToString()))
                            {
                                condition = true;
                                store = store+letter+" ";
                            }
                            
                            letter++;
                        }

                    }




                }
                if (condition==true)
                {
                    Console.WriteLine(store);
                }
                else 
                {
                    Console.WriteLine("crezy");
                }
            }

            catch (Exception)
            {

                Console.WriteLine("crezy");
            }
           
        }
    }
}
