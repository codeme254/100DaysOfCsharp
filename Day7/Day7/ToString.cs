namespace ObjectClassMethods
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"Employee({FirstName} {LastName})";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if(obj is not Employee) return false;
            return FirstName == ((Employee) obj).FirstName && 
                LastName == ((Employee) obj).LastName;
        }
    }
    internal class ToString
    {
        static void Main(string[] args)
        {
            int Number = 100;
            Console.WriteLine(Number.ToString());

            Employee e = new Employee();
            e.FirstName = "John";
            e.LastName = "Doe";
            Console.WriteLine(e.ToString());

            int Number1 = 10;
            int Number2 = 10;
            Console.WriteLine($"Number1 == Number2: {Number1 == Number2}");
            Console.WriteLine($"Number1.Equals(Number2): {Number1.Equals(Number2)}");

            Employee E1 = new Employee();
            E1.FirstName = "John";
            E1.LastName = "Doe";

            Employee E2 = new Employee();
            E2.FirstName = "John";
            E2.LastName = "Doe";

            Console.WriteLine($"E1 == E2: {E1 == E2}");
            Console.WriteLine($"E1.Equals(E2): {E1.Equals(E2)}");
        }
    }
}
