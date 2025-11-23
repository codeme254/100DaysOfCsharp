using System;

namespace Rectangular2DArray
{
    internal class Rectangular2DArray
    {
        static void Main1(string[] args)
        {
            int[,] RectangleArray = new int[4, 5];
            // Printing the values of 2D array using a foreach loop
            // It will print the defaultt values as we have not yet assigned
            // any values to the array
            foreach(int i in RectangleArray)
            {
                Console.WriteLine(i);
            }

            // Assigning values to the 2D array using nestetd for loop
            // GetLength(0): returns the size of the row
            // GetLength(1): returns the length of the column
            int a = 0;
            for (int i = 0; i < RectangleArray.GetLength(0); i++)
            {
                for (int j = 0;  j < RectangleArray.GetLength(1); j++)
                {
                    a += 5;
                    RectangleArray[i, j] = a;
                }
            }

            foreach (int i in RectangleArray)
            {
                Console.WriteLine(i);
            }

            int[,] NumbersArray = { { 11, 12, 13, 14 }, { 21, 22, 23, 24 }, { 31, 32, 33, 34 } };

            for (int i = 0; i <  NumbersArray.GetLength(0); i++)
            {
                for (int j = 0; j < NumbersArray.GetLength(1); j++)
                {
                    Console.WriteLine(NumbersArray[i, j]);
                }
            }
        }
    }
}
