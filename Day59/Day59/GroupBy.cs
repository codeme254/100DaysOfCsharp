using System;
using System.Collections.Generic;
using System.Linq;
using StudentData;

namespace GroupByMethod
{
    class StudentGroupingKey
    {
        public string Branch { get; set; }
        public string Gender {  get; set; }
    }
    internal class GroupByMethod
    {
        static void Main(string[] args)
        {
            // Method Syntax
            IEnumerable<IGrouping<string, Student>> studentGrouping = Student.GetStudents().GroupBy(s => s.Branch);
            foreach(IGrouping<string, Student> group in studentGrouping)
            {
                Console.WriteLine($"{group.Key} : {group.Count()}");
                foreach(Student student in group)
                {
                    Console.WriteLine($" {student.Name} - {student.Gender} - {student.Branch}");
                }
            }

            // Query Syntax
            studentGrouping = (from std in Student.GetStudents()
                               group std by std.Branch);
            foreach (IGrouping<string, Student> group in studentGrouping)
            {
                Console.WriteLine($"{group.Key} : {group.Count()}");
                foreach (Student student in group)
                {
                    Console.WriteLine($" {student.Name} - {student.Gender} - {student.Branch}");
                }
            }

            Console.WriteLine("==================");
            // Grouping by Branch and Gender
            IEnumerable<IGrouping<StudentGroupingKey, Student>> groupByBranchAndGender =
                Student.GetStudents()
                       .GroupBy(s => new StudentGroupingKey
                       {
                           Branch = s.Branch,
                           Gender = s.Gender
                       });

            foreach (IGrouping<StudentGroupingKey, Student> group in groupByBranchAndGender)
            {
                Console.WriteLine($"{group.Key.Branch} - {group.Key.Gender} : {group.Count()}");

                foreach (Student student in group)
                {
                    Console.WriteLine($" {student.Name} - {student.Gender} - {student.Branch}");
                }
            }

        }
    }
}
