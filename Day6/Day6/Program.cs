namespace Functions
{
    public class Employee
    {
        public int EmployeeID;
        public string Name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 25;
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine($"Square root of {number} is {squareRoot}");

            int x = 10, y = 20;
            int sum = Add(x, y);
            int product = Product(x, y);
            Console.WriteLine($"Sum of {x} and {y} is {sum}");
            Console.WriteLine($"Product of {x} and {y} is {product}");

            Console.WriteLine(Add(10, 10));
            Console.WriteLine(Add(10.5, 8));
            Console.WriteLine(Add(10, 10, 15));
            Console.WriteLine(Add(1.5, 2.7, 3.3));

            int a = 15;
            int b = a;
            b = 30;
            Console.WriteLine(a);

            Employee Emp1 = new Employee();
            Emp1.EmployeeID = 1001;
            Emp1.Name = "James";

            Employee Emp2 = Emp1;
            Emp1.Name = "Smith";
            Console.WriteLine($"Emp 1 Name = {Emp1.Name}");
            Console.WriteLine($"Emp 2 Name = {Emp2.Name}");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        static double Add(double x, double y, double z)
        {
            return x + y + z;
        }

        static int Product(int x, int y)
        {
            return x * y;
        }
    }
}
