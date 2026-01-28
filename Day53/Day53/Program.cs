using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableAndIQueryable
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            IEnumerable<int> evenNumbers = from obj in list
                              where obj % 2 == 0
                              select obj;

            foreach(int num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            IQueryable<int> oddNumbers =  list.AsQueryable()
                .Where(num =>  num % 2 != 0);

            foreach(int num in oddNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
