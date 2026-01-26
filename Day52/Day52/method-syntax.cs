using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class MethodSyntax
    {
        static void Main1(string[] args)
        {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            };

            var greaterThan5 = integerList.Where(x => x > 5).ToList();

            foreach(int item in greaterThan5)
            {
                Console.WriteLine(item);
            }

            var evenNumbers = integerList.Where(x => x % 2 == 0).ToList();

            foreach( int number in evenNumbers)
            {
                Console.WriteLine($"{number} is an even number");
            }

            var oddNumbers = integerList.Where(x => x % 2 != 0).ToList();
            
            foreach(int number in oddNumbers)
            {
                Console.WriteLine($"{number} is an odd number");
            }
        }
    }
}
