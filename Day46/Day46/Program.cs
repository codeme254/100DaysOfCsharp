using System;
using System.Diagnostics; // For Stopwatch
using System.Threading.Tasks;


namespace AsyncProgramming
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            await Task.WhenAll(DoWork(1), DoWork(2), DoWork(3));
            stopWatch.Stop();
            Console.WriteLine($"Total time taken: {stopWatch.ElapsedMilliseconds/1000}");
        }

        static async Task DoWork(int id)
        {
            await Task.Delay(1000);
            Console.WriteLine($"Task {id} done");
        }
    }
}
