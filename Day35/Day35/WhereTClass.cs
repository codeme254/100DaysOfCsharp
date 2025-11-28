using System;

namespace WhereTClass
{
    class GenericClass<T> where T : class
    {
        public T Message;
        public void GenericMethod(T Param1,  T Param2)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Param1: {Param1}");
            Console.WriteLine($"Param2: {Param2}");
        }
    }

    class Employee
    {
        public string Name {  get; set; }
        public string Location { get; set; }
    }

    class Program
    {
        static void Main1(string[] args)
        {
            GenericClass<Employee> emp = new GenericClass<Employee>(); // works fine
            //GenericClass<int> gc = new GenericClass<int>(); // Error 
        }
    }
}
