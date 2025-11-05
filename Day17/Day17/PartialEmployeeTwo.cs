using System;

namespace PartialClass
{
    public partial class PartialEmployee
    {
        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name is {FirstName} {LastName}");
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"First Name {FirstName}");
            Console.WriteLine($"Last Name {LastName}");
            Console.WriteLine($"Gender {Gender}");
            Console.WriteLine($"Salary {Salary}");
        }

        //private partial void DisplaySalary()
        //{
        //    Console.WriteLine(Salary);
        //}
    }
}
