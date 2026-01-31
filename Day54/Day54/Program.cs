using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectDemo
{
    class EmployeeBasicInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            // Select Using the Query Syntax
            IEnumerable<Employee> employees = from emp in Employee.GetEmployees()
                                              select emp;
            foreach(Employee emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }

            // Selecting using the Method Syntax
            IEnumerable<Employee> employees2 = Employee.GetEmployees().Select(e => e);
            foreach(Employee emp in employees2)
            {
                Console.WriteLine($"{emp.ID} {emp.FirstName}");
            }

            IEnumerable<int> iDsQuerySyntax = from emp in Employee.GetEmployees()
                                              select emp.ID;
            foreach(int id in iDsQuerySyntax)
            {
                Console.WriteLine(id);
            }

            IEnumerable<int> iDsMethodSyntax = Employee.GetEmployees().Select(emp => emp.ID);
            foreach(int id in iDsMethodSyntax)
            {
                Console.WriteLine(id);
            }

            IEnumerable<Employee> empDetails1 = from emp in Employee.GetEmployees()
                                                select new Employee()
                                                {
                                                    FirstName = emp.FirstName,
                                                    LastName = emp.LastName,
                                                    Salary = emp.Salary,
                                                };

            foreach(Employee emp in empDetails1)
            {
                Console.WriteLine($"{emp.FirstName} - {emp.LastName} - {emp.Salary}");
            }

            IEnumerable<Employee> empDetails2 = Employee.GetEmployees().Select(emp => new Employee()
            {
                FirstName = emp.FirstName,
                LastName = emp.LastName,
                Salary = emp.Salary
            });
            foreach(Employee emp in empDetails2)
            {
                Console.WriteLine($"{emp.FirstName} - {emp.LastName} - {emp.Salary}");
            }


            IEnumerable<EmployeeBasicInfo> basicInfo1 = from emp in Employee.GetEmployees()
                                                        select new EmployeeBasicInfo()
                                                        {
                                                            FirstName = emp.FirstName,
                                                            LastName = emp.LastName,
                                                            Salary = emp.Salary
                                                        };
            foreach(EmployeeBasicInfo emp in basicInfo1)
            {
                Console.WriteLine($"{emp.FirstName}, {emp.LastName}, {emp.Salary}");
            }

            IEnumerable<EmployeeBasicInfo> basicInfo2 = Employee.GetEmployees().Select(emp => new EmployeeBasicInfo()
            {
                FirstName = emp.FirstName,
                LastName = emp.LastName,
                Salary = emp.Salary
            });
            foreach(EmployeeBasicInfo emp in basicInfo2)
            {
                Console.WriteLine($"{emp.FirstName}, {emp.LastName}, {emp.Salary}");
            }

            var anonymous1 = from emp in Employee.GetEmployees()
                             select new
                             {
                                 FirstName = emp.FirstName,
                                 LastName = emp.LastName,
                                 Salary = emp.Salary
                             };
            foreach(var emp in anonymous1)
            {
                Console.WriteLine($"{emp.FirstName}_{emp.LastName}_{emp.Salary}");
            }

            var anonymous2 = Employee.GetEmployees().Select(emp => new
            {
                FirstName = emp.FirstName,
                LastName = emp.LastName,
                Salary = emp.Salary
            });

            foreach(var emp in anonymous2)
            {
                Console.WriteLine($"{emp.FirstName}_{emp.LastName}_{emp.Salary}");
            }
        }
    }
}
