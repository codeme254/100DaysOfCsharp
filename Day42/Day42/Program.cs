using System;
using System.Threading.Tasks;

namespace TaskDemo
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

        async static void ExecuteSomeMethod()
        {
            await SomeMethod();
        }

        async static Task SomeMethod()
        {
            Console.WriteLine("Some Method Started");
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("Some Method Ended");
        }
    }
}
