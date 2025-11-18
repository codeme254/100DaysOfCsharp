using System;
using System.Threading;

namespace ThreadingDemo2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            ThreadStart obj = new ThreadStart(DisplayNumbers);
            Thread t1 = new Thread(obj);
            t1.Start();

            //Thread t1 = new Thread(new ThreadStart(DisplayNumbers));
            //t1.Start();
        }

        static void DisplayNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
