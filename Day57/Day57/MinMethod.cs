using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeData;

namespace MinMethod
{
    internal class MinMethod
    {
        static void Main1(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                10, 30, 50, 40, 60, 20, 70, 90, 80, 100
            };
            int min = numbers.Min();
            Console.WriteLine(min);

            min = (from num in numbers
                   select num).Min();
            Console.WriteLine(min);

            int gt50Min = numbers.Min(num =>
            {
                if (num > 50) return num;
                return null;
            }).GetValueOrDefault();
            Console.WriteLine(gt50Min);

            gt50Min = (from num in numbers
                       select num).Min(num =>
                       {
                           if (num > 50) return num;
                           return null;
                       }).GetValueOrDefault();
            Console.WriteLine(gt50Min);

            int lowestSalary = Employee.GetAllEmployees().Min(e => e.Salary);
            Console.WriteLine(lowestSalary);

            lowestSalary = (from emp in  Employee.GetAllEmployees()
                            select emp).Min(e => e.Salary);
            Console.WriteLine(lowestSalary);
        }
    }
}
