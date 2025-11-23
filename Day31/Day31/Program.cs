using System;

namespace Arrays
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int[] empno = { 1001, 1002, 5003, 1004, 2005 };
            Console.WriteLine(empno[0]); // 1001
            Console.WriteLine(empno[1]); // 1002

            string[] students = new string[5];
            students[0] = "John";
            students[1] = "Ruth";
            students[2] = "Jane";
            students[3] = "Kane";
            students[4] = "June";
            Console.WriteLine(students.Length);

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"students[{i}] is {students[i]}");
            }

            foreach(string student in students)
            {
                Console.WriteLine(student);
            }

            var Numbers = new[] { 10, 20, 30, 40, 50 };
            foreach(var number in Numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
