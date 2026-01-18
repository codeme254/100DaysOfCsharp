using System;

namespace DelegatesReview
{
    internal class Program
    {
        delegate void GreetDelegate(string username);

        delegate void Callback(string s);

        static void DoSomeWork(Callback cb)
        {
            Console.WriteLine("Doing some work");
            cb("Hello world");
        }

        static void ExampleCallback(string s)
        {
            Console.WriteLine(s);
        }

        static void SayHello(string name)
        {
            int i = 10;
            int j = 20;
            int age = i + j;
            Console.WriteLine($"Hello {name}, you are {age} years old");
        }

        static void SayGoodBye(string username)
        {
            Console.WriteLine($"Goodbye {username}");
        }

        static void Main1(string[] args)
        {
            GreetDelegate del1 = new GreetDelegate(Program.SayHello);
            del1("John");
            del1.Invoke("Kasparin");

            GreetDelegate del = new GreetDelegate((username) =>
            {
                Console.WriteLine($"Nice to see you {username}");
            });
            del("Kennedy");

            del = new GreetDelegate((username) =>
            {
                Console.WriteLine($"How's the going {username}");
            });
            del("Ann");

            Callback cb = new Callback(ExampleCallback);
            DoSomeWork(cb);
        }
    }
}
