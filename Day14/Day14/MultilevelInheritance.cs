using System;


namespace MultilevelInheritance
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

    class C : B
    {
        public void Method3()
        {
            Console.WriteLine("This is method 3");
        }
    }
    internal class MultilevelInheritance
    {
        //static void Main(string[] args)
        //{
        //    C c = new C();
        //    c.Method1();
        //    c.Method2();
        //    c.Method3();
        //}
    }
}
