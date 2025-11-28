using System;

namespace WhereTStruct
{
    class GenericClass<T> where T : struct
    {
        public T Message;
        public void GenericMethod(T Param1, T Param2)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Param1: {Param1}");
            Console.WriteLine($"Param2: {Param2}");
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }

    class Program
    {
        static void Main1(string[] args)
        {
            //GenericClass<Employee> emp = new GenericClass<Employee>(); // Error
            GenericClass<int> gc = new GenericClass<int>(); // works fine
        }
    }
}
