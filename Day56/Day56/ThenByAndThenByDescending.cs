using System;
using System.Collections.Generic;
using System.Linq;
using Students;

namespace ThenByAndThenByDescendingMethods
{
    internal class ThenByAndThenByDescending
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("===Before ThenByDescending===");
            IEnumerable<Student> students = Student.GetAllStudents().OrderBy(s => s.FirstName);
            foreach(Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            Console.WriteLine("\n\n===After ThenByDescending===");
            students = Student.GetAllStudents().OrderBy(s => s.FirstName).ThenByDescending(s => s.LastName);
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
    }
}
