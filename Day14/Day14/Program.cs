using System;

namespace Inheritance
{
    class A
    {
        public A(int number)
        {
            Console.WriteLine("Constructor of A executed");
            Console.WriteLine($"Number is {number}");
        }
        public void Method1()
        {
            Console.WriteLine("This is Method1");
        }

        public void Method2()
        {
            Console.WriteLine("This is Method2");
        }
    }

    class B : A
    {
        public B(int num) : base(num)
        {
            Console.WriteLine("Constructor of B executed");
        }
        public void Method2()
        {
            Console.WriteLine("This is Method 2");
        }
    }
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    A a = new A(5);
        //}
    }
}
