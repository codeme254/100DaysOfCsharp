using System;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method started");
            ExecuteSomeMethod();
            Console.WriteLine("Main method ended");
            Console.ReadKey();
        }

        static async void ExecuteSomeMethod()
        {
            await SomeMethod();
        }

        static async Task SomeMethod()
        {
            Console.WriteLine("Some method started");
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("Some method ended");
        }
    }
}