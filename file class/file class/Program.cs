using System;
using System.IO;

namespace file_class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamWriter streams = File.CreateText("file.text");
            Console.WriteLine("hello man!");
            streams.Close();
        }
    }
}
