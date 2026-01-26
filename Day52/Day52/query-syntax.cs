using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            // Data source
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            };

            var numbersGreaterThan5 = from obj in integerList // Data Source
                                      where obj > 5 // Condition
                                      select obj; // Selection
            foreach(int item in numbersGreaterThan5)
            {
                Console.WriteLine($"{item}");
            }

            var evenNumbers = from obj in integerList
                              where obj % 2 == 0
                              select obj;
            foreach(int number  in evenNumbers)
            {
                Console.WriteLine($"{number} is an even number");
            }

            var oddNumbers = from obj in integerList
                             where obj % 2 != 0
                             select obj;
            foreach(int number in  oddNumbers)
            {
                Console.WriteLine($"{number} is an odd number");
            }
        }
    }
}
