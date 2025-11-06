using System;

namespace StaticClasses
{
    static class Math
    {
        public static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
    }
    internal class StaticClasses
    {
        static void Main(string[] args)
        {
            Math.Add(10, 2);
            Math.Multiply(10, 2);
        }
    }
}
