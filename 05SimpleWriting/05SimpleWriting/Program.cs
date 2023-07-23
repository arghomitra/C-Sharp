using System;
using System.IO;

namespace _05SimpleWriting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //making a file
            string path = Path.Combine(@"E:\", "file.txt");


            /*
             StreamWriter stream = File.CreateText(path);

            //write text out the stream, to the document
            stream.Write("Hello world");
            stream.Close();
             */


           if(File.Exists(path))
            {
                StreamWriter output = File.AppendText(path);
                output.WriteLine("not cool!");
                output.Close();
            }

        }
    }
}
