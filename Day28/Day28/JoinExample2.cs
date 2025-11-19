using System;
using System.Threading;

namespace JoinAndIsAlive2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);
            Thread thread3 = new Thread(Method3);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            // Main thread will wait for 3 seconds and wait thread2 to complete its execution
            if (thread2.Join(TimeSpan.FromSeconds(3)))
            {
                Console.WriteLine("Thread 2 Execution Completed in 3 Seconds");
            } else
            {
                Console.WriteLine("Thread 2 execution not completed in 3 seconds");
            }

            if (thread3.Join(3000))
            {
                Console.WriteLine("Thread 3 completed execution in 3 seconds");
            } else
            {
                Console.WriteLine("Thread 3 did not complete execution in 3 seconds");
            }
                Console.WriteLine("Main Thread Ended");
        }

        static void Method1()
        {
            Console.WriteLine("Method1 - thread1 started");
            Thread.Sleep(3000);
            Console.WriteLine("Method1 - thread1 ended");
        }

        static void Method2()
        {
            Console.WriteLine("Method2 - thread2 started");
            Thread.Sleep(2000);
            Console.WriteLine("Method2 - thread2 ended");
        }

        static void Method3()
        {
            Console.WriteLine("Method3 - thread3 started");
            Thread.Sleep(5000);
            Console.WriteLine("Method3 - thread3 ended");
        }
    }
}
