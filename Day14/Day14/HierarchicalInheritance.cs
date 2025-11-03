using System;

namespace HierarchicalInheritance
{
    class A
    {
        public void Method1()
        {
            Console.WriteLine("This is the first method");
        }
    }

    class B : A
    {
        public void Method2()
        {
            Console.WriteLine("This is Method 2");
        }
    }

    class C : A
    {
        public void Method3()
        {
            Console.WriteLine("This is Method 3");
        }
    }

    class D : A
    {
        public void Method4()
        {
            Console.WriteLine("This is Method 4");
        }
    }
    internal class HierarchicalInheritance
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Method1();
            b.Method2();

            C c = new C();
            c.Method1();
            c.Method3();

            D d = new D();
            d.Method1();
            d.Method4();
        }
    }
}
