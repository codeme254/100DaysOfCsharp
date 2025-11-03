using System;

namespace SingleInheritance
{
    class A
    {
        public void Method1()
        {
            Console.WriteLine("This is method 1");
        }
    }

    class B : A
    {
        public void Method2()
        {
            Console.WriteLine("This is method 2");
        }
    }
    internal class SingleInheritance
    {
        //static void Main(string[] args)
        //{
        //    B b = new B();
        //    b.Method1();
        //    b.Method2();
        //}
    }
}
