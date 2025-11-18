using System;
using System.Threading;

namespace ThreadingDemo
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Thread t1 = new Thread(DisplayNumbers);
            t1.Start();
        }

        static void DisplayNumbers()
        {
            for (int i  = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
