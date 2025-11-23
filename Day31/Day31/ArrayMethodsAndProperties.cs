using System;

namespace Arrays
{
    internal class ArrayMethodsAndProperties
    {
        static void Main1(string[] args)
        {
            int[] Numbers = { 17, 23, 4, 59, 27, 36, 96, 9, 1, 3 };
            
            // Number of elements in an array
            Console.WriteLine(Numbers.Length); // 10

            // Printing original array elements using a for loop
            Console.WriteLine("Array elements before sorting");
            for (int i = 0; i <  Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }

            // Sorting Array Elements
            Array.Sort(Numbers);
            // Printing array elements using the for each loop
            Console.WriteLine("\nSorted array elementts");
            foreach(int number in Numbers)
            {
                Console.WriteLine(number);
            }

            // Reversing array elements
            Array.Reverse(Numbers);
            Console.WriteLine("\nReversed Array elements");
            foreach(int number in Numbers)
            {
                Console.WriteLine(number);
            }

            // COPYING ARRAY ELEMENTS
            // ======================
            // Copying some elements from the old array to a new array
            // We will declare the array with size 10 but we will only copy 5 elements
            // The rest 5 elements in the new array will take a default value, 0 for the case of integers
            int[] NewNumbers = new int[10];
            Array.Copy(Numbers, NewNumbers, 5);
            Console.WriteLine("\nNew array elements");
            foreach(int number in NewNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"\nLength of the new array using Length property: {NewNumbers.Length}");
            Console.WriteLine($"Length of the new array using the GetLength property: {NewNumbers.GetLength(0)}");
        }
    }
}
