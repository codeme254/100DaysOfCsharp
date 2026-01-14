using System;
using System.Threading.Tasks;

namespace AsyncProgrammingExample
{
    internal class Program1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Main method started");
            SomeMethod();
            Console.WriteLine("Main method ended");
            Console.ReadKey();
        }

        static async void SomeMethod()
        {
            Console.WriteLine("Some method started");
            Wait();
            Console.WriteLine("Some method ended");
        }

        static async void Wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("5 Seconds completed");
        }
    }
}
