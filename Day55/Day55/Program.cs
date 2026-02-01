using System;
using System.Collections.Generic;
using System.Linq;

namespace WhereDemo
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Method Syntax
            IEnumerable<int> filterdData1 = numbers.Where(number => number > 5 && number % 2 == 0);
            
            foreach(int num in filterdData1)
            {
                Console.WriteLine(num);
            }

            // Query Syntax
            IEnumerable<int> filteredData2 = from num in numbers
                                             where num > 5
                                             select num;
            foreach(int num in filteredData2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
