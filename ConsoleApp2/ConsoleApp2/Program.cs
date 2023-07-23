/*using System;
using System.Runtime.Serialization.Json;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
string word = "AaaabbbdddCCCCeeeeeffff";  //A3a3b3d4C5e4f
            
            //string count = string.Empty;
            
            string store = string.Empty;
            string stores = string.Empty;
            char[] charArr = word.ToCharArray();

            //for (int i = 0; i < charArr.Length; i++)
            //{
            //    if (store != charArr[i])
            //    {
            //        store = charArr[i];
            //        Console.Write(charArr[i]);
            //    }
            //    if (store == charArr[i])
            //    {

            //        nu++;
            //    }


            //}
            //Console.Write(nu);

            //foreach (var letter in charArr)
            //{
            //    if (!store.Contains(letter))
            //    {
            //        store = store + letter;
            //    }
            //    else if(store.Contains(letter))
            //    {
            //        stores=stores+letter;
            //    }
            //    else if (true)
            //    {

            //    }

            //}
            //Console.WriteLine(store);
            //Console.WriteLine(stores);
            int count = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == charArr[i+1])
                {

                }
            }
        }
    }
}
*/
using System;

namespace RunLengthEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
        
            String newWord = String.Empty;
            int count = 1;
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i + 1])
                {      
                    count++;
                }
                else
                {

                    newWord = newWord + count;
                    newWord = newWord + word[i];
                    
                    count = 1;
                }

            }
           
            Console.WriteLine(newWord);  //A3a3b3d4C5e4f
        }
    }
}