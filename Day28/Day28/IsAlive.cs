using System;
using System.Threading;

namespace IsAlive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            Thread thread1 = new Thread(Method1);
            thread1.Start();

            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread1 Method1 is still executing");
            } else
            {
                Console.WriteLine("Thread1 Method1 completed its work");
            }

            // Making the main thread to wait till thread1 has finished
            // to visualize IsAlive being false
            thread1.Join();
            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread1 Method1 is still executing");
            }
            else
            {
                Console.WriteLine("Thread1 Method1 completed its work");
            }
            Console.WriteLine("Main Thread Ended");
        }

        static void Method1()
        {
            Console.WriteLine("Method1 - Thread1 Started");
            Thread.Sleep(2000);
            Console.WriteLine("Method1 - Thread1 Ended");
        }
    }
}
