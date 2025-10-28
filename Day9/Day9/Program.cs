namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an object (instance of the calculator class)
            Calculator c = new Calculator();
            // Accessing Calculator class member using an object
            Console.WriteLine(c.Sum(5, 6));
        }
    }

    // Defininig a class
    class Calculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
