using System;
using System.Threading;

namespace Threading
{
    internal class Example3
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread for method 1"
            };
            Thread t2 = new Thread(Method2)
            {
                Name = "Thread for method 2"
            };
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread for method 3"
            };
            t1.Start();
            t2.Start();
            t3.Start();
        }
        static void Method1()
        {
            Console.WriteLine($"Method 1 started using {Thread.CurrentThread.Name}");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Method 1: {i}");
            }
            Console.WriteLine($"Method 1 ended using {Thread.CurrentThread.Name}");
        }

        static void Method2()
        {
            Console.WriteLine($"Method 2 started using {Thread.CurrentThread.Name}");
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Fake database operation started");
                    Thread.Sleep(10000);
                    Console.WriteLine("Fake database operatin completed");
                }
                Console.WriteLine($"Method 2: {i}");
            }
            Console.WriteLine($"Method 2 ended using {Thread.CurrentThread.Name}");
        }

        static void Method3()
        {
            Console.WriteLine($"Method 3 started using {Thread.CurrentThread.Name}");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Method 3: {i}");
            }
            Console.WriteLine($"Method 3 ended using {Thread.CurrentThread.Name}");
        }
    }
}
