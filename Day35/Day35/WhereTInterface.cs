using System;

namespace WhereTInterface
{
    interface IEmployee { };
    class GenericClass<T> where T : IEmployee
    {
        public T Message;
        public void GenericMethod(T Param1, T Param2)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Param1: {Param1}");
            Console.WriteLine($"Param2: {Param2}");
        }
    }

    class Employee : IEmployee
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
        static void Main(string[] args)
        {
            // Works fine
            GenericClass<Employee> e = new GenericClass<Employee>();
            GenericClass<IEmployee> e2 = new GenericClass<IEmployee>();

            // Error
            //GenericClass<Customer> c = new GenericClass<Customer>();
        }
    }
}
