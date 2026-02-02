using System;
using System.Collections.Generic;
using System.Linq;
using Students;

namespace OrderByDescendingOperator
{
    internal class OrderByDescending
    {
        static void Main1(string[] args)
        {
            List<int> intList = new List<int>()
            {
                10, 45, 35, 29, 100, 69, 58, 50
            };

            // Method Syntax
            IEnumerable<int> sorted1 = intList.OrderByDescending(x => x);
            foreach(int i in sorted1)
            {
                Console.WriteLine(i);
            }

            // Query Syntax
            IEnumerable<int> sorted2 = from i in intList
                                       orderby i descending
                                       select i;
            foreach(int i in sorted2)
            {
                Console.WriteLine(i);
            }

            // Sorting Students in Descending order based on the Branch
            // Method Syntax
            IEnumerable<Student> branch1 = Student.GetAllStudents().OrderByDescending(s => s.Branch);
            foreach(Student s in branch1)
            {
                Console.WriteLine($"{s.Branch} - {s.FirstName} {s.LastName}");
            }

            // Query Syntax
            IEnumerable<Student> branch2 = from s in Student.GetAllStudents()
                                           orderby s.Branch descending
                                           select s;
            foreach(Student s in branch2)
            {
                Console.WriteLine($"{s.Branch} - {s.FirstName} {s.LastName}");
            }
        }
    }
}
