using System;
using System.Threading;

namespace ThreadingDemo2
{
    class NumberHelper
    {
        private int _Number;
        public NumberHelper(int Number)
        {
            _Number = Number;
        }
        public void DisplayNumbers()
        {
            for (int i = 1; i <= _Number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Program
    {
        static void Main1(string[] args)
        {
            int Max = 10;
            NumberHelper nh = new NumberHelper(Max);
            Thread t1 = new Thread(nh.DisplayNumbers);
            t1.Start();
        }
    }
}