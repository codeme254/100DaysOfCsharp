using System;

namespace ExtensionMethods
{
    public class MyMath
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public void Add()
        {
            int sum = Number1 + Number2;
            Console.WriteLine($"Sum of {Number1} and {Number2} is {sum}");
        }
    }

    public static class NewMyMath
    {
        public static void Multiply(this MyMath m)
        {
            int product = m.Number1 * m.Number2;
            Console.WriteLine($"Product of {m.Number1} and {m.Number2} is {product}");
        }

        public static void Divide(this MyMath m)
        {
            int division = m.Number1 / m.Number2;
            Console.WriteLine($"Division between {m.Number1} and {m.Number2} is {division}");
        }

        public static void Difference(this MyMath m)
        {
            int difference = m.Number1 - m.Number2;
            Console.WriteLine($"Difference in {m.Number1} and {m.Number2} is {difference}");
        }
    }
    internal class ExtensionMethods
    {
        //static void Main( string[] args )
        //{
        //    MyMath m = new MyMath()
        //    {
        //        Number1 = 15,
        //        Number2 = 3,
        //    };
        //    m.Add();
        //    m.Multiply();
        //    m.Divide();
        //    m.Difference();
        //}
    }
}
