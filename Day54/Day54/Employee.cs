using System.Collections.Generic;

namespace SelectDemo
{
    class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee { ID = 101, FirstName = "John", LastName = "Doe", Salary = 60000 },
                new Employee { ID = 102, FirstName = "Jane", LastName = "Doe", Salary = 70000 },
                new Employee { ID = 103, FirstName = "Jack", LastName = "Ripper", Salary = 80000 },
                new Employee { ID = 104, FirstName = "Ken", LastName = "Thompson", Salary = 90000 },
                new Employee { ID = 105, FirstName = "Alison", LastName = "Krugger", Salary = 100000 },
                new Employee { ID = 106, FirstName = "Bill", LastName = "Ackman", Salary = 160000 },
            };
        }
    }
}
