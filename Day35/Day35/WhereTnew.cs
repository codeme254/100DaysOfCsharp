using System;

namespace WhereTnew
{
    class GenericClass<T> where T : new()
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

    class Customer
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public Customer(string cName, string cLocation)
        {
            Name = cName;
            Location = cLocation;
        }
    }

    class Program
    {
        static void Main1(string[] args)
        {
            // Works fine because Employee has a public parameterless contructor
            // REM: if we don't specify a constructor, there's always a default
            // public parameterless constructor
            GenericClass<Employee> e = new GenericClass<Employee>();

            // Will not work because Customer has no public parameterless contructor
            //GenericClass<Customer> c = new GenericClass<Customer>();
        }
    }
}
