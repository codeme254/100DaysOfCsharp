using System;

namespace CheckedAndUnchecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Max integer value is: {int.MaxValue}");
            int a = 2147483647;
            int b = 2147483647;
            int c = checked(a + b);
            Console.WriteLine(c);

            const int num1 = 2147483647;
            const int num2 = 2147483647;
            int sum = unchecked(num1 + num2);
            Console.WriteLine(sum);
        }
    }
}