namespace ParameterizedConstructor
{
    internal class ParameterizedConstructor
    {
        //static void Main(string[] args)
        //{
        //    Employee e1 = new Employee("John", "Doe", 24);
        //    e1.Display();

        //    Employee e2 = new Employee("Jack", "Smith", 38);
        //    e2.Display();

        //    Employee e3 = new Employee("Alison", "Krugger", 20);
        //    e3.Display();
        //}
    }
    class Employee
    {
        string FirstName, LastName;
        int Age;
        // Parameterized constructor
        public Employee(string F_Name, string L_Name, int A_Age) 
        {
            FirstName = F_Name;
            LastName = L_Name;
            Age = A_Age;
        }

        public void Display()
        {
            Console.WriteLine($"FirstName: {FirstName}");
            Console.WriteLine($"LastName: {LastName}");
            Console.WriteLine($"Age: {Age}");
        }
    }
}
