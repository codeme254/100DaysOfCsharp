using System;

namespace WhereTBaseClass
{
    class GenericClass<T> where T : BaseEmployee
    {
        public T Message;
        public void GenericMethod(T Param1, T Param2)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Param1: {Param1}");
            Console.WriteLine($"Param2: {Param2}");
        }
    }

    class BaseEmployee { }

    class Employee : BaseEmployee
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }

    class Customer
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }

    class Program
    {
        static void Main1(string[] args)
        {
            // Works fine
            GenericClass<Employee> e = new GenericClass<Employee>();

            // Error
            //GenericClass<Customer> c = new GenericClass<Customer>();
        }
    }
}
