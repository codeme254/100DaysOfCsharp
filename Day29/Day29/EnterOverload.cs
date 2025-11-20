using System;
using System.Threading;

namespace MonitorClass
{
    internal class EnterOverload
    {
        static object lockPrintNumbers = new object();
        static void PrintNumbers()
        {
            bool isLockTaken = false;
            Console.WriteLine($"{Thread.CurrentThread.Name} trying to enter the critical section");
            try
            {
                Monitor.Enter(lockPrintNumbers, ref isLockTaken);
                if (isLockTaken )
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} has entered the critical section");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine();
                }
            }
            finally
            {
                if (isLockTaken)
                {
                    Monitor.Exit(lockPrintNumbers);
                    Console.WriteLine($"{Thread.CurrentThread.Name} has exited from the critical section");
                }
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
