using System;

namespace Functions
{
    internal class Functions
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(Product(5, 5));
        }
        // A simple function
        static int Product(int a, int b)
        {
            return a * b;
        }

        // Function/Method Overloading
        static int Add(int a, int b)
        {
            return a + b;
        }

        static float Add(float a, float b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static float Add(float a, float b, float c)
        {
            return a + b + c;
        }
    }
}
