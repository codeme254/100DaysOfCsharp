using System;
using System.Threading;

namespace MutexDemo
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            using(Mutex mutex = new Mutex(false, "MutexDemo"))
            {
                // Check of another external thread is running
                if (!mutex.WaitOne(500,false))
                {
                    Console.WriteLine("An instance of the application is already running");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Application is running...");
                Console.ReadKey();
            }
        }
    }
}
