using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeData;

namespace MaxMethod
{
    class MaxMethod
    {
        static void Main1(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                10, 30, 50, 40, 60, 20, 70, 90, 80, 100
            };
            
            // Method syntax
            int max = numbers.Max();
            Console.WriteLine(max);

            // Query syntax
            max = (from num in  numbers
                   select num).Max();
            Console.WriteLine(max);

            // Max among numbers that are less than 50
            int lt50Max = numbers.Max(num =>
            {
                if (num < 50) return num;
                return 0;
            });
            Console.WriteLine(lt50Max);

            lt50Max = (from num in numbers
                       select num).Max(num =>
                       {
                           if (num < 50) return num;
                           return 0;
                       });
            Console.WriteLine(lt50Max);

            // Find the highest salary
            int highestSalary = Employee.GetAllEmployees().Max(e =>  e.Salary);
            Console.WriteLine(highestSalary);

            highestSalary = (from emp in Employee.GetAllEmployees()
                             select emp).Max(e => e.Salary);
            Console.WriteLine(highestSalary);
        }
    }
}
