using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeData;

namespace AddMethod
{
    internal class AddMethod
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>()
            {
                60, 80, 50, 90, 10, 30, 70, 40, 20, 100
            };

            int count = nums.Count();
            Console.WriteLine(count);
            count = (from num in nums
                     select num).Count();
            Console.WriteLine(count);

            int gt40Count = nums.Count(num => num > 40);
            Console.WriteLine(gt40Count);

            gt40Count = (from num in nums
                         select num).Count(num => num > 40);
            Console.WriteLine(gt40Count);

            int numEmployeesInIt = Employee.GetAllEmployees().Count(e => e.Department == "IT");
            Console.WriteLine(numEmployeesInIt);

            numEmployeesInIt = (from emp in Employee.GetAllEmployees()
                                select emp).Count(e => e.Department == "IT");
            Console.WriteLine(numEmployeesInIt);
        }
    }
}
