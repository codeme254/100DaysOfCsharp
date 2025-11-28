using System;

namespace Generics
{
    internal class ClsMain
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(ClsCalculator.AreEqual<int>(10, 20));
            Console.WriteLine(ClsCalculator.AreEqual<string>("Hello", "Hello"));
            Console.WriteLine(ClsCalculator.AreEqual<bool>(true, false));
            Console.WriteLine(ClsCalculator.AreEqual<byte>(99, 25));
            Console.WriteLine(ClsCalculator.AreEqual<float>(19.9f, 19.9f));
            Console.WriteLine(ClsCalculator.AreEqual<double>(8.5, 8.5));
        }
    }

    class ClsCalculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
