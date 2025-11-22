using System;
using System.Threading;

namespace MutexExample
{
    internal class Program
    {
        private static Mutex mutex = new Mutex();

        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread threadObject = new Thread(MutexDemo)
                {
                    Name = $"Thread {i}"
                };
                threadObject.Start();
            }
        }
        static void MutexDemo()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} wants to enter criticla section for processing");
            try
            {
                // Blocks the current thread until the current waitONe method receives a signal

                // wait until it is safer to enter
                mutex.WaitOne();
                Console.WriteLine($"Success: {Thread.CurrentThread.Name} is processing now.");
                Thread.Sleep(2000);
                Console.WriteLine($"Exit: {Thread.CurrentThread.Name} has completed its task.");
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }
    }
}
