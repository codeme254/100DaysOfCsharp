using System;
using System.Threading;

namespace MonitorClass
{
    internal class MonitorClass
    {
        static object lockPrintNumbers = new object();
        static void PrintNumbers()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} trying to enter the critical section");
            try
            {
                Monitor.Enter(lockPrintNumbers);
                Console.WriteLine($"{Thread.CurrentThread.Name} has entered the critical section");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            finally
            {
                Monitor.Exit(lockPrintNumbers);
                Console.WriteLine($"{Thread.CurrentThread.Name} has exited from the critical section");
            }
        }

        static void Main1(string[] args)
        {
            Thread t1 = new Thread(PrintNumbers)
            {
                Name = "Thread 1"
            };
            Thread t2 = new Thread(PrintNumbers)
            {
                Name = "Thread 2"
            };
            Thread t3 = new Thread(PrintNumbers)
            {
                Name = "Thread 3"
            };
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
