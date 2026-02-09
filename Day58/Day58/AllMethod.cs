using System;
using System.Collections.Generic;
using System.Linq;
using StudentData;

namespace AllMethod
{
    internal class AllMethod
    {
        static void Main1(string[] args)
        {
            List<int> nums = new List<int>()
            {
                11, 22, 33, 44, 55
            };

            bool allGT10 = nums.All(num => num > 10);
            if(allGT10)
            {
                Console.WriteLine("All numbers are greater than 10");
            } 
            else
            {
                Console.WriteLine("Not all numbers are greater than 10");
            }

            allGT10 = (from num in nums
                       select num).All(num => num > 10);
            if (allGT10)
            {
                Console.WriteLine("All numbers are greater than 10");
            }
            else
            {
                Console.WriteLine("Not all numbers are greater than 10");
            }

            bool allGt250 = Student.GetStudents().All(s => s.TotalMarks > 250);
            Console.WriteLine(allGt250);

            allGt250 = (from s in Student.GetStudents()
                        select s).All(s => s.TotalMarks > 250);
            Console.WriteLine(allGt250);

            IEnumerable<Student> result = Student.GetStudents().Where(s => s.Subjects.All(st => st.Marks > 80));

            foreach(Student student in result)
            {
                Console.WriteLine($"{student.Name}");
                foreach(Subject subject in student.Subjects)
                {
                    Console.WriteLine($" {subject.SubjectName} - {subject.Marks}");
                }
            }

            result = (from s in Student.GetStudents()
                      select s).Where(s => s.Subjects.All(st => st.Marks > 80));

            foreach (Student student in result)
            {
                Console.WriteLine($"{student.Name}");
                foreach (Subject subject in student.Subjects)
                {
                    Console.WriteLine($" {subject.SubjectName} - {subject.Marks}");
                }
            }
        }
    }
}
