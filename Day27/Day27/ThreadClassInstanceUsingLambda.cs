using System;
using System.Threading;

namespace ThreadingDemo4
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Thread t1 = new Thread(() =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            });
            t1.Start();
        }
    }
}
