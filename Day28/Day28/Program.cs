using System;
using System.Threading;

namespace ThreadingDemo
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            ParameterizedThreadStart ptsd = new ParameterizedThreadStart(DisplayNumbers);
            Thread t1 = new Thread(ptsd);
            t1.Start("Hi"); // we should pass a number but nothing prevents us from passing anything else
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