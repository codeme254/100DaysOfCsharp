using System;

namespace Delegates
{
    internal class DelegateExample
    {
        public delegate void GreetDelegate(string name);

        void SayHello(string username)
        {
            Console.WriteLine($"Hello {username}");
        }

        void SayGoodbye(string nameOfUser)
        {
            Console.WriteLine($"Goodbye {nameOfUser}");
        }
        static void Main1(string[] args)
        {
            DelegateExample de = new DelegateExample();

            GreetDelegate del1 = new GreetDelegate(de.SayHello);
            //del1("John Doe");
            del1.Invoke("John Doe");

            GreetDelegate del2 = new GreetDelegate(de.SayGoodbye);
            //del2("Jane Doe");
            del2.Invoke("Jane Doe");
        }
    }
}
