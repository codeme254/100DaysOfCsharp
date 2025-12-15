using System;

namespace Review
{
    class Employee
    {
        private int _EmpId;
        private string _Name;
        private string _Email;
        private int _Age;

        // public property for _EmpId
        public int EmployeeId
        {
            get
            {
                return _EmpId;
            }

            set
            {
                _EmpId = value;
            }
        }

        // Public property for _Name
        public string EmployeeName
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        // Public property for Email
        public string EmployeeEmail
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        // Public property for Age
        public int EmployeeAge
        {
            get
            {
                return _Age;
            }

            set
            {
                _Age = value;
            }
        }

        public void PrintEmployeeDetails()
        {
            Console.WriteLine(_EmpId);
            Console.WriteLine(_Name);
            Console.WriteLine(_Email);
            Console.WriteLine(_Age);
        }

        public override string ToString()
        {
            return $"Employee(EmpId: {_EmpId}, Name: {_Name}, Email: {_Email}, Age: {_Age})";
        }
    }


    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Dog(Name: {Name}, Age: {Age})";
        }
    }
    internal class Properties
    {
        static void Main1(string[] args)
        {
            Employee emp = new Employee();
            emp.EmployeeId = 1;
            emp.EmployeeName = "John Doe";
            emp.EmployeeEmail = "jd@gmail.com";
            emp.EmployeeAge = 33;
            Console.WriteLine(emp);

            Dog d = new Dog();
            d.Name = "Scoob";
            d.Age = 5;
            Console.WriteLine(d);
        }
    }
}
