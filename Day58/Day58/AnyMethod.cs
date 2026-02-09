using System;
using System.Collections.Generic;
using System.Linq;
using StudentData;

namespace AnyMethod
{
    internal class AnyMethod
    {
        static void Main1(string[] args)
        {
            List<int> nums = new List<int>()
            {
                11, 22, 33, 44, 55
            };
            bool anyGT50 = nums.Any(x => x > 50);
            Console.WriteLine(anyGT50);

            anyGT50 = (from num in nums 
                       select num).Any(x => x > 50);
            Console.WriteLine(anyGT50);

            bool anyHasGT250 = Student.GetStudents().Any(s => s.TotalMarks > 250);
            Console.WriteLine(anyHasGT250);

            anyHasGT250 = (from student in Student.GetStudents()
                           select student).Any(s => s.TotalMarks > 250);
            Console.WriteLine(anyHasGT250);
        }
    }
}
