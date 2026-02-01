using System;
using System.Collections.Generic;
using System.Linq;

namespace DistinctOperator
{
    internal class DistinctOperator
    {
        static void Main1(string[] args)
        {
            List<int> nums = new List<int>()
            {
                1, 2, 3, 2, 3, 4, 4, 5, 6, 3, 4, 5
            };

            // Method syntax
            IEnumerable<int> unique = nums.Distinct();
            foreach(int num in unique)
            {
                Console.WriteLine(num);
            }

            // Query Syntax
            IEnumerable<int> unique2 = (from num in nums
                                       select num).Distinct();
            foreach(int num in unique2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
