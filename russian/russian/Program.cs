using System;
using System.IO;

namespace russian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = File.OpenText("Russian.txt");
            string line = input.ReadLine();
            while (line != null)
            {
                line = input.ReadLine();
                
                
            }
            input.Close();

        }
    }
}
