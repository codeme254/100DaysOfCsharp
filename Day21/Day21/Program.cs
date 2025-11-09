using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int a = 20;
            int b = 0;
            int c;
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero");
            } else
            {
                Console.WriteLine($"A = {a}");
                Console.WriteLine($"B = {b}");
                c = a / b;
                Console.WriteLine($"C = {c}");
            }
        }
    }
}
