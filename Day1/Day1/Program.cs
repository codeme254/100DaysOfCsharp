using System;

namespace ConsoleClass
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "C# is Awesome";
            Console.WriteLine(Console.Title); // C# is Awesome

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(Console.BackgroundColor);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Console.ForegroundColor);


            Console.Write("Hello, World");
            Console.WriteLine("Hello, World");

            Console.Write("Type a character: ");
            int value = Console.Read();
            Console.WriteLine("Ascii is " + value);

            Console.Write("What is your full name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.Write("Press Any key: ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(key);
        }
        
    }
}
