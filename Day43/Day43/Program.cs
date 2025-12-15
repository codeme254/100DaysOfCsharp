using System;

namespace Review
{
    class Sample
    {
        public const string username = "John";
        public readonly int age;
        public readonly string major = "Computer Science";

        public Sample(int a)
        {
            age = a;
        }
    }
    internal class Program
    {
        const float pi = 3.142f;
        static void Main1(string[] args)
        {
            const float myNum = 33.5f;
            Console.WriteLine(myNum);
            Console.WriteLine(pi);
            Console.WriteLine(Sample.username);

            Sample s = new Sample(25);
            Console.WriteLine(s.age);
            Console.WriteLine(s.major);
        }
    }
}
