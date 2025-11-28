using System;

namespace Generics
{
    // Generic Class
    // T specifies the data type of the class members
    class MyGenericClass<T>
    {
        // Generic variable
        private T GenericMemberVariable;

        // Generic property
        public T GenericProperty { get; set; }

        // Generic constructor
        public MyGenericClass(T value)
        {
            GenericMemberVariable = value;
        }

        // Generic Method
        public T GenericMethod(T GenericParameter)
        {
            Console.WriteLine($"Parameter type: {typeof(T)}");
            Console.WriteLine($"Return type: {typeof(T)}");
            return GenericMemberVariable;
        }
    }

    class MainCls
    {
        static void Main1(string[] args)
        {
            MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);
            Console.WriteLine(intGenericClass.GenericMethod(200));
        }
    }
}
