using System;
using System.Threading.Tasks;

namespace AsyncProgrammingExample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string message = await SayHello("John");
            Console.WriteLine(message);
        }

        static async Task<string> SayHello(string username)
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return $"Hello {username}";
        }
    }
}
