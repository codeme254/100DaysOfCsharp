using System;

namespace LambdaExpressions
{
    internal class Program
    {
        public delegate string GreetingDelegate(string name);

        static void Main(string[] args)
        {
            GreetingDelegate gd =  name =>
            {
                return $"Hello {name}, how do you do";
            };
            string msg = gd.Invoke("Dennis");
            Console.WriteLine(msg);
        }
    }
}
