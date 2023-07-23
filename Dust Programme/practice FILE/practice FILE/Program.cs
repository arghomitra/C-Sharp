using System;
using System.IO;
namespace practice_FILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
           StreamReader input = File.OpenText("tyu.txt");
            string text = input.ReadToEnd();

            
            foreach(char c in text)
            {
               
                Console.Write(c +" ");
            }input.Close();
        }
    }
}
