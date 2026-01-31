using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectManyDemo
{
    class SelectMany
    {
        static void Main(string[] args)
        {
            var numbers = new List<List<int>>()
            {
                new List<int>() { 1, 2, 3 },
                new List<int>() { 4, 5 },
                new List<int>() { 6 }
            };

            IEnumerable<int> flattened = numbers.SelectMany(num => num);
            foreach(int num in flattened)
            {
                Console.WriteLine(num);
            }

            IEnumerable<int> flattened2 = from numbersList in numbers
                                          from number in numbersList
                                          select number;
            foreach(int number in flattened2)
            {
                Console.WriteLine(number);
            }

            IEnumerable<string> programming1 = Student.GetStudents().SelectMany(student => student.Programming);
            foreach(string  programming in programming1)
            {
                Console.WriteLine(programming);
            }

            IEnumerable<string> programming2 = from student in Student.GetStudents()
                                               from program in student.Programming
                                               select program;
            foreach(string program in programming2)
            {
                Console.WriteLine(program);
            }
        }
    }
}
