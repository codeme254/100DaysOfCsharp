using System;
using System.Collections.Generic;
using System.Linq;

namespace ExceptMethod
{
    internal class ExceptOperator
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

            // Method Syntax
            IEnumerable<int> except = nums1.Except(nums2);
            foreach (int x in except)
            {
                Console.WriteLine(x);
            }

            // Query Syntax
            IEnumerable<int> except2 = (from num in nums1
                                        select num).Except(nums2);
            foreach(int num in except2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
