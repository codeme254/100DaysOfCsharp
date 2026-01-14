using System;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    internal class Program1
    {
        static async Task Main1(string[] args)
        {
            Console.WriteLine("Main method started");
            await SomeMethod();
            Console.WriteLine("Main method ended");
            Console.ReadKey();
        }

        static async Task SomeMethod()
        {
            Console.WriteLine("Some method started");
            await Wait();
            Console.WriteLine("Some method ended");
        }

        static async Task Wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("5 Seconds completed");
        }
    }
}
