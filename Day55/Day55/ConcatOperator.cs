using System;
using System.Collections.Generic;
using System.Linq;

namespace ConcatOperator
{
    internal class ConcatOperator
    {
        static void Main(string[] args)
        {
            List<int> nums1 = new List<int>()
            {
                1, 2, 3, 4
            };
            List<int> nums2 = new List<int>()
            {
                2, 4, 6, 8
            };

            // Method Syntax
            IEnumerable<int> concat1 = nums1.Concat(nums2);
            foreach(int i in concat1)
            {
                Console.WriteLine(i);
            }

            // Query Syntax
            IEnumerable<int> concat2 = (from num in nums1
                                        select num).Concat(nums2);
            foreach(int i in concat2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
