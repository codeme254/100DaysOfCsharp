using Students;
using System;
using System.Collections.Generic;
using System.Linq;
//using Student;

namespace OrderByOperator
{
    internal class OrderByOperator
    {
        static void Main1(string[] args)
        {
            List<int> intList = new List<int>()
            {
                10, 45, 35, 29, 100, 69, 58, 50
            };

            // Method Syntax
            IEnumerable<int> sorted1 = intList.OrderBy(num => num);
            foreach(int num in sorted1)
            {
                Console.WriteLine(num);
            }

            // Query Syntax
            IEnumerable<int> sorted2 = from num in intList
                                       orderby num
                                       select num;
            foreach(int num in sorted2)
            {
                Console.WriteLine(num);
            }

            // Sorting Students based on branch
            // Method Syntax
            IEnumerable<Student> branch1 = Student.GetAllStudents().OrderBy(s => s.Branch);
            foreach(Student s in branch1)
            {
                Console.WriteLine($"{s.Branch} - {s.FirstName} {s.LastName}");
            }
            // Query Syntax
            IEnumerable<Student> branch2 = from student in Student.GetAllStudents()
                                           orderby student.Branch
                                           select student;
            foreach(Student s in branch2)
            {
                Console.WriteLine($"{s.Branch} - {s.FirstName} {s.LastName}");
            }
        }
    }
}
