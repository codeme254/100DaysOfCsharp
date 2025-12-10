using System;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method started");
            SomeMethod();
            Console.WriteLine("Main method ended");
            Console.ReadKey();
        }

        async static void SomeMethod()
        {
            Console.WriteLine("SomeMethod started");
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("SomeMethod ended");
        }
    }
}
