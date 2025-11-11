using System;
using System.Threading;

namespace Threading
{
    internal class Example2
    {
        static void Main1(string[] args)
        {
            Method1();
            Method2();
            Method3();
        }
        static void Method1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Method 1: {i}");
            }
        }

        static void Method2()
        {
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
        }

        static void Method3()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Method 3: {i}");
            }
        }
    }
}
