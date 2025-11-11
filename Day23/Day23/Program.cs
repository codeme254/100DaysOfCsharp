using System;
using System.Threading;

namespace ThreadingDemo
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine($"Current executing thread name: {t.Name}");
            Console.WriteLine($"Current executing thread name: {Thread.CurrentThread.Name}");
        }
    }
}
