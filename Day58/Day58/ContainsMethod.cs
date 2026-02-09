using System;
using System.Linq;

namespace ContainsMethod
{
    internal class ContainsMethod
    {
        static void Main(string[] args)
        {
            int[] nums = { 11, 22, 33, 44, 55 };

            bool exists33 = nums.Contains(33);
            Console.WriteLine(exists33);

            exists33 = (from num in nums
                        select num).Contains(33);
            Console.WriteLine(exists33);
        }
    }
}
