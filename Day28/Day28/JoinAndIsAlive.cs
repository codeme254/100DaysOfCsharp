using System;
using System.Threading;

namespace JoinAndIsAlive
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

            thread1.Join();
            thread2.Join();
            thread3.Join();

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
