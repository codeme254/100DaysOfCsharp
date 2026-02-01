using System;
using System.Collections.Generic;
using System.Linq;

namespace UnionOperator
{
    internal class UnionOperator
    {
        static void Main1(string[] args)
        {
            List<int> nums1 = new List<int>()
            {
                1, 2, 3, 4, 5, 6
            };
            List<int> nums2 = new List<int>()
            {
                1, 3, 5, 8, 9, 10
            };

            // Method syntax
            IEnumerable<int> union1 = nums1.Union(nums2);
            foreach(int num in union1)
            {
                Console.WriteLine(num);
            }

            // Query Syntax
            IEnumerable<int> union2 = (from num in nums1
                                       select num).Union(nums2);
            foreach(int num in union2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
