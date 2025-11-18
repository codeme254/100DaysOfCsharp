using System;
using System.Threading;

namespace ThreadingDemo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(DisplayNumbers);
            t1.Start(10);
        }

        static void DisplayNumbers(object max)
        {
            int limit = Convert.ToInt32(max);
            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
