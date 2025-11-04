using System;

namespace MethodHiding
{
    class Class1
    {
        public void Show()
        {
            Console.WriteLine("Show method in the parent");
        }
    }

    class Class2 : Class1
    {
        public new void Show()
        {
            Console.WriteLine("Show method in the child");
        }
    }
    internal class MethodHiding
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.Show();

            Class2 c2 = new Class2();
            c2.Show();
        }
    }
}
