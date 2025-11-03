using System;

namespace AbstractClassesAndMethods
{
    abstract class AbstractClass
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
    }

    class AbstractChild : AbstractClass
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    AbstractChild c = new AbstractChild();
        //    c.Mul(5, 3);
        //    c.Div(5, 3);
        //    c.Add(5, 3);
        //    c.Sub(5, 3);
        //}
    }
}
