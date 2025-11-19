using System;
using System.Threading;

namespace ThreadingDemo3
{
    public delegate void ResultCallbackDelegate(int Results);
    class NumberHelper
    {
        private int _Number;
        private ResultCallbackDelegate _resultCallbackDelegate;
        public NumberHelper(int Number, ResultCallbackDelegate ResultCallbackDelegate)
        {
            _Number = Number;
            _resultCallbackDelegate = ResultCallbackDelegate;
        }

        public void CalculateSum()
        {
            int Result = 0;
            for (int i = 1; i <= _Number; i++)
            {
                Result = Result + i;
            }
            // Before the end of the thread function, call the callback method
            if (_resultCallbackDelegate != null)
            {
                _resultCallbackDelegate(Result);
            }
        }
    }

    class Program
    {
        static void Main1(string[] args)
        {
            ResultCallbackDelegate rcd = new ResultCallbackDelegate(ResultCallBackMethod);
            int Number = 10;
            NumberHelper nh = new NumberHelper(Number, rcd);
            Thread t1 = new Thread(nh.CalculateSum);
            t1.Start();
        }

        public static void ResultCallBackMethod(int Result)
        {
            Console.WriteLine($"Result is {Result}");
        }
    }

}