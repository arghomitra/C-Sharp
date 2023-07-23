using System;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Security.Cryptography;

namespace arrayFastTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * 
             string[] array = Array.ConvertAll(Console.ReadLine().Split(' '));
             double[] doubles = Array.ConvertAll(array,Double.Parse);

             foreach (var item in doubles)
             {
                 Console.Write(item+1+" ");
              }
            */
            /*string[] numbers =Console.ReadLine().Split(' ');
            string[] num = Console.ReadLine().Split(' ');

            int[] numArray = new int[numbers.Length+1];
            
            string[] result = numbers.Concat(num).ToArray();

            Array.Sort(result);



            for (int i = 0; i < numbers.Length+1; i++)
            {
                numArray[i] = Convert.ToInt32(result[i]);
            }
            foreach (var item in numArray)
            {
                Console.Write(item + " ");
            }
            *//*
            int[] numbers = {1,2,3,5,6};
            int num = 4;

            string store = String.Empty;

            int[] numbersArray = new int[numbers.Length+1];
            numbersArray[0] = num;
            for (int i = 1; i < numbers.Length + 1; i++)
            {
                if (true)
                {

                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (num < numbers[i])
                {
                    store += num.ToString();
                }
                else if (num > numbers[i])
                {
                    store += numbers[i].ToString();
                }
            }
            Console.WriteLine(store);*/


            /*
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[i])
                    {
                        // Swap the elements at indices i and j
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }*/
            /*
            int[] numbers = { 5, 3, 15, 1, 2, -4, 4, 7, 6 };
            

            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            */
            //string[] number = (Console.ReadLine()).Split(" ");
            //
            /*
            int[] number = { 1 ,7 ,3 ,4,5 , 9 ,8 };

            int max = number[0];


            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > max)
                {
                    max = number[i];
                }


            }
            int min = max;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < min)
                {
                    min = number[i];
                }

            }



            int sum = 0;
            for (int i = min; i <= max; i++)
            {
                sum = sum + i;

            }


            int count = 0;
            for (int i = 0; i < number.Length; i++)
            {
                count = count + number[i];

            }




            if (sum != count)
            {
                Console.WriteLine(sum - count);
            }
            else
            {
                Console.WriteLine("There is no missing link!");
            }
            */
            /*
            StreamReader input = File.OpenText("Beyonce.txt");
            string file = ((input.ReadToEnd().Replace(";"," ")).Replace("/", " ")).Replace("-", " ");
            input.Close();
            //Console.WriteLine(file);
            //Console.WriteLine(file);
            Regex pattern = new Regex(@"\s\d{1,3}\s");
            MatchCollection matches = pattern.Matches(file);
            foreach (var items in matches)
            {
                Console.WriteLine(items);
            }
            int sum = 0;
            foreach (var item in matches)
            {
                sum+=Convert.ToInt32(item.ToString());
            }
            Console.WriteLine(sum);

            */
            /*
            string sequence = Console.ReadLine();
            string[] sequenceArray = new string[sequence.Length];
            sequenceArray[0] = sequence;
            
            for (int i = 1; i < sequence.Length; i++)
            {
                sequence = Console.ReadLine();
                sequenceArray[i] = sequence;
            }
           
            for (int i = sequenceArray.Length - 1; i >=0; i--)
            {
                Console.WriteLine(sequenceArray[i]);
            }
            
            */
            /*
              string[] inputArray = Console.ReadLine().Split(" ");
              string word1,word2,store;
              word1 = inputArray[0];
              word2 = inputArray[1];
              store = string.Empty;

              int i = 1;
                  while (word1[word1.Length - i] == word2[word2.Length - i])
                  {
                      store = word1[word1.Length - i]+store;
                  i++;
                  }

              Console.WriteLine(store);

  */
            /*
             * 
             * 
            string numbers = "6 2 18 17 18 17 18 15 17 2 4 12 18 18 18";
            int[] numbersArray =Array.ConvertAll( numbers.Split(" "),int.Parse);


            for (int i = 0; i < numbersArray.Length-1; i++)
            {
                for (int j = i+1; j < numbersArray.Length; j++)
                {
                    int temp = numbersArray[i];
                    numbersArray[i] = numbersArray[j];
                    numbersArray[j] = temp;

                }
            }

*/
            /*

            string word1 = Console.ReadLine().Replace(" ","");
            char[] araWord1 = word1.ToCharArray();


            for (int i = 0; i < araWord1.Length-1; i++)
            {
                for (int j = i+1; j < araWord1.Length; j++)
                {
                    char c = araWord1[i];
                    araWord1[i] = araWord1[j];
                    araWord1[j] = c;
                }
            }
            string word2 = Console.ReadLine().Replace(" ", "");
            char[] araWord2 = word1.ToCharArray();


            for (int i = 0; i < araWord2.Length - 1; i++)
            {
                for (int j = i + 1; j < araWord2.Length; j++)
                {
                    char c = araWord2[i];
                    araWord2[i] = araWord2[j];
                    araWord2[j] = c;
                }
            }
            string ami = string.Join("", araWord1);

            string tumi = string.Join("", araWord2);

            if (ami==tumi)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            

          */
            /*
            string word1 = Console.ReadLine().ToLower();
            string word2 = Console.ReadLine().ToLower();

            int count = 0;

            for (int i = 0; i < word1.Length; i++)
            {
                if (word2.Contains(word1[i]))
                {
                    count++;
                }
            }
            if ((count == word1.Length) )
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            */

            /*
             double sum = 0;
             for (double i = 1; i <= 2; i++)
             {
                double count = 1 / i;
                 sum = sum+count;

             }

             Console.WriteLine(Math.Round(sum,4));
            */
            /*
            int start = 1;
            for (int i = 1; i <=5; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }
            */
            /*
            int multiplication = 1;
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                multiplication = multiplication*i;

            }
            Console.WriteLine(multiplication);
           */
            /*
           string input = Console.ReadLine();
            string store = string.Empty;
            if (input!="x")
            {
                store = input;
            }
            while (input != "x")
            {
                input = Console.ReadLine();
                if (input != "x")
                {
                    store += input;
                }
            }
            for (int i = 0; i < store.Length; i++)
            {

            }

            */
            /*
            string input = "DXII";
            char[] chars = input.ToCharArray();
            int sum = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i]=='M')
                {
                   sum =sum + 1000;
                }
                else if (chars[i] == 'D')
                {
                    sum = sum + 500;
                }
                else if (chars[i] == 'C')
                {
                    sum = sum + 100;
                }
                else if (chars[i] == 'L')
                {
                    sum = sum + 50;
                }
                else if (chars[i] == 'D')
                {
                    sum = sum + 500;
                }
                else if (chars[i] == 'X')
                {
                    sum = sum + 10;
                }
                else if (chars[i] == 'V')
                {
                    sum = sum + 5;
                }
                else if (chars[i] == 'I')
                {
                    sum = sum + 1;
                }
                
            }

            Console.WriteLine(sum);

            */
            /*
            string input = Console.ReadLine().ToUpper();
            string Wrong_ans = "Wrong_ans";
            int sum = 0;

            foreach (char item in input)
            {
                switch (item)

                {
                    case 'X':
                        sum = sum + 10;
                        break;


                         case 'V':
                        sum = sum + 5;
                        break;


                         


                         case 'I':
                        sum = sum + 1;
                        break;


                         


                    default:
                        Console.WriteLine(Wrong_ans);
                        continue;
                }
                
            
            }
            Console.WriteLine(sum);
            */

            /*
            Console.WriteLine("Read in a number n and print all prime numbers between 2 and n. ");
            Console.WriteLine("what is the value of n?");
            int n = int.Parse(Console.ReadLine());
            string store = "2";

            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j < n - 1; j++)   // 10  = 1,10    (2,5)
                {
                    if (i % j == 0)
                        break;
                    else
                        store +=" "+ i.ToString();
                }

            }
            Console.WriteLine(store);
            if (n < 2)

                Console.WriteLine("crazy input");

            */


            /*
            int num = 10;
            string store = string.Empty;
            for (int i = 1; i < num; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j != 0)
                    {
                        store += i.ToString();
                        
                    }
                }
            }
            Console.WriteLine(store);

            */

            int num = 10;
            string store = string.Empty;
            for (int i = 1; i <= num; i++)
            {
                bool result i != 100;
                if(result)
                {
                    Console.WriteLine(ytresk);
                }

            }





        }
    
    }
}
