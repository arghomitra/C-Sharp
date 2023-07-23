using System;

namespace monstar
{
    internal class Program
    {
        static void question1()
        {
            int year = Convert.ToInt32(Console.ReadLine());

            for (int i = year + 1; i <= year + 4; i++)
            {
                int sum = i % 4;
                int sum2 = i % 100;
                if (sum == 0)
                {
                    Console.WriteLine(i);
                }


                else if (sum2 == 0)
                {
                    int sum3 = i % 400;
                    if (sum3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
        }
        
        static void question2()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int num = input;
            int sum = 0;
            int number = input;
            while (num > 9)
            {

                sum = 0;
                int devide = 0;
                int remainder = 0;
                while (number != 0)
                {
                    remainder = number % 10;
                    sum = sum + remainder;
                    devide = number / 10;
                    number = devide;
                }
                number = sum;
                num = sum;
            }
            Console.WriteLine(sum);
        }
        static void question3()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int calculation = 5 * (number * number) + 4;
            int calculation2 = 5 * (number * number) - 4;
            double result = (Math.Sqrt(calculation)) - (Math.Round(Math.Sqrt(calculation)));
            double result2 = (Math.Sqrt(calculation2)) - (Math.Round(Math.Sqrt(calculation2)));
            if (result == 0 || result2 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static void question4()
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 1)
            {
                for (int i = n + 1; i > n; i++)
                {
                    bool prime = true;
                    int divider = 2;
                    int maxDivider = (int)Math.Sqrt(i);
                    while (divider <= maxDivider)
                    {
                        if (i % divider == 0)
                        {
                            prime = false;
                            break;
                        }
                        divider++;
                    }
                    if (prime)
                    {
                        Console.Write(i + " ");
                        break;
                    }
                }
            }
        }

        static void question5()
        {

            string input = Console.ReadLine();
            string[] strArray = new string[input.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] = input[i].ToString();
            }
            foreach (var item in strArray)
            {
                int ascii = Convert.ToInt32(Convert.ToChar(item));
                if (ascii >= 97 && ascii <= 122)
                {
                    Console.Write(item.ToString().ToUpper());
                }
                else if (ascii >= 65 && ascii <= 90)
                {
                    Console.Write(item.ToString().ToLower());
                }
                else
                {
                    Console.Write(item.ToString());
                }
            }
        }
        static void question6()
        {
            string input = Console.ReadLine().ToLower();
            string text = input.Replace(" ", "");
            string[] textArray = new string[text.Length];
            string newText = string.Empty;
            for (int i = 0; i < textArray.Length; i++)
            {
                textArray[i] = text[i].ToString();
            }
            for (int i = textArray.Length - 1; i >= 0; i--)
            {
                newText = newText + textArray[i];
            }
            if (newText == text)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static void question7()
        {
            string[] words = Console.ReadLine().ToLower().Split(",");



            string word1 = words[0].Replace(" ", "");
            string[] word1Array = new string[word1.Length];
            string newText1 = string.Empty;
            for (int i = 0; i < word1Array.Length; i++)
            {
                word1Array[i] = word1[i].ToString();
            }
            Array.Sort(word1Array);
            for (int i = 0; i < word1Array.Length; i++)
            {
                newText1 = newText1 + word1Array[i];
            }



            string word2 = words[1].Replace(" ", "");
            string[] word2Array = new string[word2.Length];
            string newText2 = string.Empty;
            for (int i = 0; i < word2Array.Length; i++)
            {
                word2Array[i] = word2[i].ToString();
            }
            Array.Sort(word2Array);
            for (int i = 0; i < word2Array.Length; i++)
            {
                newText2 = newText2 + word2Array[i];
            }

            if (newText1 == newText2)
            {
                Console.WriteLine("True");
               
            }
            else
            {
                Console.WriteLine("False");
                 
            }
        }
        static void question8()
        {
            string input = Console.ReadLine().ToLower();
            string text = input.Replace(" ", "");
            string[] strArray = new string[text.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] = text[i].ToString();
            }
            int sum = 0;
            foreach (var item in strArray)
            {
                int position = Convert.ToInt32(Convert.ToChar(item.ToString())) - 96;
                if (position>=1 && position <= 26)
                {
                    sum = sum + position;
                }
                
            }
            Console.WriteLine(sum);
        }
        static void question9()
        {
            string[] strNumbers = Console.ReadLine().Split(",");
            int[] arrayNumbers = Array.ConvertAll(strNumbers, int.Parse);
            int num1 = arrayNumbers[0];
            int num2 = arrayNumbers[1];
            Console.WriteLine(num1*num2);
        }
        static void question10()
        {
            string[] strNumbers = Console.ReadLine().Split(",");
            int[] arrayNumbers = Array.ConvertAll(strNumbers, int.Parse);
            int num1 = arrayNumbers[0];
            int num2 = arrayNumbers[1];
            if (num1 > num2)
            {
                string divisor = string.Empty;
                for (int i = 2; i <= num2; i++)
                {
                    if (num1 % i == 0 && num2 % i == 0)
                    {
                        divisor += i.ToString();
                    }
                }
                Console.WriteLine(divisor[divisor.Length - 1]);
            }
            else if (num1 < num2)
            {
                string divisor = string.Empty;
                for (int i = 2; i <= num1; i++)
                {
                    if (num1 % i == 0 && num2 % i == 0)
                    {
                        divisor += i.ToString();
                    }
                }
                Console.WriteLine(divisor[divisor.Length - 1]);
            }
        }
        static void Main(string[] args)
        {
            string question = Console.ReadLine();
            switch (question)
            {
                case "1":
                question1();
                break;
                    case "2":
                    question2();
                    break;
                case "3":
                    question3();
                    break;
                case "4":
                    question4();
                    break;

                case "5":
                question5();
                break;
                case "6":
                    question6();
                    break;
                case "7":
                    question7();
                    break;
                case "8":
                    question8();
                    break;
                case "9":
                    question9();
                    break;

                case "10":
                    question10();
                    break;

                
            }
            

        }
    }
}
