using System;

namespace SealedClasses
{
    partial class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public virtual void DisplayEmployeeDetails()
        {
            Console.WriteLine($"First name: {FirstName}");
            Console.WriteLine($"Last name: {LastName}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    sealed class Manager : Employee
    {
        public int Bonus { get; set; }
        public override void DisplayEmployeeDetails()
        {
            base.DisplayEmployeeDetails();
            Console.WriteLine($"Bonus: {Bonus}");
        }
    }
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Manager m = new Manager()
        //    {
        //        FirstName = "John",
        //        LastName = "Doe",
        //        Salary = 200000,
        //        Bonus = 60000
        //    };
        //    m.DisplayEmployeeDetails();
        //}
    }
}
