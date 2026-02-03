using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeData;

namespace SumMethod
{
    internal class SumMethod
    {
        static void Main1(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                10, 30, 50, 40, 60, 20, 70, 90, 80, 100
            };

            int total1 = numbers.Sum();
            int total2 = (from num in numbers
                          select num).Sum();

            Console.WriteLine(total1);
            Console.WriteLine(total2);

            int gt50total = numbers.Sum(num =>
            {
                if (num > 50) return num;
                return 0;
            });
            Console.WriteLine(gt50total);

            gt50total = (from num in numbers
                         select num).Sum(num =>
                         {
                             if (num > 50) return num;
                             return 0;
                         });
            Console.WriteLine(gt50total);


            // Method syntax
            int total = Employee.GetAllEmployees().Sum(e => e.Salary);
            Console.WriteLine(total);

            // Query Syntax
            total = (from emp in Employee.GetAllEmployees()
                     select emp).Sum(e => e.Salary);
            Console.WriteLine(total);
        }
    }
}
