using System;

namespace MethodOverloading
{
    class AddNumbers
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public void Add(int num1, int num2, int num3)
        {
            Console.WriteLine(num1 + num2 + num3);
        }

        public void Add(float num1, float num2) 
        { 
            Console.WriteLine(num1 + num2); 
        }

        public void Add(float num1, float num2, float num3)
        {
            Console.WriteLine(num1 + num2 + num3);
        }
    }

    internal class MethodOverloading
    {
        //static void Main(string[] args)
        //{
        //    AddNumbers a = new AddNumbers();
        //    a.Add(5, 5);
        //    a.Add(3.5f, 2.2f);
        //    a.Add(10, 20, 30);
        //    a.Add(55.6f, 2.3f, 9.9f);
        //}
    }
}
