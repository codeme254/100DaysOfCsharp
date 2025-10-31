using System;

namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        private protected int Id;
        public void Display1()
        {
            Console.WriteLine(Id);
        }
    }

    public class AssemblyOneClass2 : AssemblyOneClass1
    {
        public void Display2()
        {
            Console.WriteLine(Id);
        }
    }

    public class AssemblyOneClass3
    {
        public void Display3()
        {
            AssemblyOneClass1 obj = new AssemblyOneClass1();
            Console.WriteLine(obj.Id);
        }
    }
}