using System;

namespace Interfaces
{
    interface IMath
    {
        void Add(int x, int y);
        void Sub(int x, int y);
        void Mul(int x, int y);
        void Div(int x, int y);
    }

    class Math : IMath
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        public void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        public void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        public void Mod(int x, int y)
        {
            Console.WriteLine(x % y);
        }
    }
    internal class Interfaces
    {
        static void Main(string[] args)
        {
            IMath m = new Math();
            m.Mul(5, 3);
            m.Sub(5, 3);
            m.Add(5, 3);
            m.Div(5, 3);
            //m.mod(5, 3); // Error
        }
    }
}
