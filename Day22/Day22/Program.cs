using System;

namespace Delegates
{
    internal class Program
    {
        // Delegate
        public delegate void GreetDelegate(string name);

        // SayHello method that matches the signature of GreetDelegate delegate
        static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
            Console.WriteLine($"How do you do {name}");
        }

        // SayGoodbye method that matches the signature of GreetDelegate delegate
        static void SayGoodbye(string name)
        {
            Console.WriteLine($"Goodbye {name}");
        }
        static void Main1(string[] args)
        {
            GreetDelegate greet;
            greet = SayHello;
            greet("Dennis");

            greet = SayGoodbye;
            greet("Dennis");
        }
    }
}
