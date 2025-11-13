using System;

namespace Delegates
{
    internal class Program
    {
        public delegate void GreetDelegate(string name);

        static void SayHello(string username)
        {
            Console.WriteLine($"Hello {username}");
        }

        static void SayGoodbye(string nameOfUser)
        {
            Console.WriteLine($"Goodbye {nameOfUser}");
        }
        static void Main1(string[] args)
        {
            // Since our handler method is static and we are in the same
            // class, we can access the handler method without an instance
            // or even the class name.
            GreetDelegate del1 = new GreetDelegate(SayHello);
            del1("John Doe"); // Hello John Doe

            // We can access the handler method using the class name if we want to
            // since the handler method is static
            GreetDelegate del2 = new GreetDelegate(Program.SayGoodbye);
            del2("John Doe"); // Goodbye John Doe
        }
    }
}
