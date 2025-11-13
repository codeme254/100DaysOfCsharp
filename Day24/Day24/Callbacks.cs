using System;

namespace Callbacks
{
    public delegate void Callback(string username);
    internal class Callbacks
    {
        static void Main(string[] args)
        {
            Callback del = new Callback(ExampleCallback);
            DoSomeWork(del);
        }

        static void DoSomeWork(Callback cb)
        {
            Console.WriteLine("Some work has been completed...");
            cb("John Doe.");
        }

        static void ExampleCallback(string username)
        {
            Console.WriteLine("This is the callback method");
            Console.WriteLine($"Hello {username}");
        }
    }
}
