using System;

namespace MulticastDelegate2
{
    public delegate int ExampleDelegate();
    internal class Rectangle
    {
        int Method1()
        {
            return 1;
        }

        int Method2()
        {
            return 2;
        }
        static void Main1(string[] args)
        {
            Rectangle r = new Rectangle();
            ExampleDelegate del = new ExampleDelegate(r.Method1);
            del += r.Method2;

            Console.WriteLine($"Value returned by delegate {del()}");
        }
    }
}
