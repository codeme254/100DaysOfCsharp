using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeData;

namespace AverageMethod
{
    class AverageMethod
    {
        static void Main1(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                10, 30, 50, 40, 60, 20, 70, 90, 80, 100
            };

            double avg = numbers.Average();
            Console.WriteLine(avg);

            avg = (from num in numbers
                   select num).Average();
            Console.WriteLine(avg);

            double gt50Avg = numbers.Average(num =>
            {
                if (num > 50) return num;
                return 0;
            });
            Console.WriteLine(gt50Avg);

            gt50Avg = (from num in numbers
                       select num).Average(num =>
                       {
                           if (num > 50) return num;
                           return 0;
                       });
            Console.WriteLine(gt50Avg);

            double avgSalary = Employee.GetAllEmployees().Average(e => e.Salary);
            Console.WriteLine(avgSalary);

            avgSalary = (from emp in Employee.GetAllEmployees()
                         select emp).Average(e => e.Salary);
            Console.WriteLine(avgSalary);
        }
    }
}
