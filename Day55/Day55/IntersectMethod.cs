using System;
using System.Collections.Generic;
using System.Linq;

namespace IntersectMethod
{
    internal class IntersectMethod
    {
        static void Main1(string[] args)
        {
            List<int> nums1 = new List<int>()
            {
                1, 2, 3, 4, 5, 6,
            };
            List<int> nums2 = new List<int>()
            {
                1, 3, 5, 8, 9, 10
            };

            // Method Syntax
            IEnumerable<int> intersection1 = nums1.Intersect(nums2);
            foreach(int num in intersection1)
            {
                Console.WriteLine(num);
            }

            // Query Syntax
            IEnumerable<int> intersection2 = (from num in nums1
                                              select num).Intersect(nums2);
            foreach(int num in intersection2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
