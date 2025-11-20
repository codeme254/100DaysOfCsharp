using System;
using System.Threading;

namespace WithoutSynchronization
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Thread t1 = new Thread(SomeMethod);
            Thread t2 = new Thread(SomeMethod);
            Thread t3 = new Thread(SomeMethod);
            t1.Start();
            t2.Start();
            t3.Start();
        }

        static void SomeMethod()
        {
            Console.Write("[Welcome to the");
            Thread.Sleep(1000);
            Console.WriteLine("world of C#]");
        }
    }
}
