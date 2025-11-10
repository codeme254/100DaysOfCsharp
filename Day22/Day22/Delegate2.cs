using System;

namespace Delegates
{
    internal class Delegates
    {
        // Delegate
        public delegate void GreetDelegate(string name);

        // SayHello method that matches the signature of GreetDelegate delegate
        void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
            Console.WriteLine($"How do you do {name}");
        }

        // SayGoodbye method that matches the signature of GreetDelegate delegate
        void SayGoodbye(string name)
        {
            Console.WriteLine($"Goodbye {name}");
        }
        static void Main(string[] args)
        {
            Delegates d = new Delegates();
            GreetDelegate greet;
            greet = d.SayHello;
            greet("Dennis");

            GreetDelegate gd = new GreetDelegate(d.SayHello);
            gd("Dennis");
            gd = new GreetDelegate(d.SayGoodbye);
            gd("Dennis");
        }
    }
}
