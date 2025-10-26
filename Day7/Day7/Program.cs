namespace ConstAndReadonly
{
    internal class Program
    {
        const float PI = 3.14f;
        // Initializing a readonly variable at the place of creation
        readonly int number = 99;
        readonly int age;

        public Program() 
        {
            // Initializing a readonly variable inside of a constructor
            age = 55;
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine($"The value of PI is {Program.PI}");

        //    const int number = 25;
        //    Console.WriteLine(number);

        //    // you need an instance of the class to work with readonly variables.
        //    Program p = new Program();
        //    Console.WriteLine($"Number is {p.number}");
        //    Console.WriteLine($"Age is {p.age}");
        //}
    }
}
