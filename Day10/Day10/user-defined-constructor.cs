namespace UserDefinedConstructor
{
    class Employee
    {
        public int Id, Age;
        public string Address, Name;
        public bool IsPermanent;

        public Employee()
        {
            Id = 100;
            Age = 30;
            Address = "Nairobi";
            Name = "John";
            if (Age > 25)
            {
                IsPermanent = true;
            } else
            {
                IsPermanent = false;
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"IsPermanent: {IsPermanent}");
        }
    }
    internal class UserDefinedConstructor
    {
        //static void Main( string[] args )
        //{
        //    Employee employee = new Employee();
        //    employee.DisplayDetails();
        //}
    }
}
