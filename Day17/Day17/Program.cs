namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartialEmployee employee = new PartialEmployee()
            {
                FirstName = "John",
                LastName = "Doe",
                Gender = "Male",
                Salary = 90000
            };
            employee.DisplayFullName();
            employee.DisplayDetails();
        }
    }
}
