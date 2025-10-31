using AssemblyOne;
using System;

namespace AccessSpecifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class AnotherAssemblyClass1 : AssemblyOneClass1
    {
        public void Display4()
        {
            Console.WriteLine(Id);
        }
    }

    public class AnotherAssemblyClass2
    {
        public void Display5()
        {
            AnotherAssemblyClass1 obj = new AnotherAssemblyClass1();
            Console.WriteLine(obj.Id); // Error
        }
    }
}
