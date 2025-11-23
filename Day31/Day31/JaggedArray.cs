using System;


namespace JaggedArray
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[4][];
            arr[0] = new int[5];
            arr[1] = new int[6];
            arr[2] = new int[4];
            arr[3] = new int[5];

            Console.WriteLine("Default values of the Jagged array");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0 ; j < arr[i].Length; j++)
                {
                    Console.WriteLine(arr[i][j]);
                }
            }

            // Dynamically assinging values to the jagged array using a nested for loop
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int num = 10;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    num++;
                    arr[i][j] = num;
                }
            }

            // Printing the values of the jagged array by using a foreach loop within a for loop
            for (int i = 0; i < arr.Length; i++)
            {
                foreach(int x in  arr[i])
                {
                    Console.Write($"{x} ");
                }
                Console.Write("\n");
            }
        }
    }
}
