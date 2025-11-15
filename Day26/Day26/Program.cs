using System;

namespace AnonymouseMethods
{
    internal class Program
    {
        public delegate string GreetingDelegate(string name);

        static void Main1(string[] args)
        {
            GreetingDelegate gd = delegate (string name)
            {
                return $"Hello {name}, how do you do";
            };
            string msg = gd.Invoke("Dennis");
            Console.WriteLine(msg);
        }
    }
}
