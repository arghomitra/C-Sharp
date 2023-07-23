using System;

namespace jagged_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[][] myjaggedArray = new int[5][];
            myjaggedArray[0] = new int[2];
            myjaggedArray[1] = new int[10];

            myjaggedArray[0][0] =19;
            myjaggedArray[0][1] = 7;
            myjaggedArray[1] = new int[] { 19, 4, 20, 10, 5 };

            for (int i = 0; i < myjaggedArray.Length; i++)
            {
                //looping over the rows!
                //each row has a different length,so watch out!

// looping over the colums
                for (int j = 0; j < myjaggedArray[i].Length; j++)
                {//printing out each element
                    Console.Write(myjaggedArray[i][j] +"\t");
                }
// each row gets a new line
                Console.Write("\n");

            }

        }
    }
}
