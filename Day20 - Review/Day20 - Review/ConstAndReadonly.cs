using System;
using System.Runtime.InteropServices;

namespace ConstAndReadonly
{
    internal class ConstAndReadonly
    {
        const float x = 99.99f;
        static void Main(string[] args)
        {
            // CONSTANTS
            // =========
            // If we declare a variable using the const keyword, it becomes a constant variable and the
            // value of a constant variable cannot be modified after it's declaration.
            // constants are static by default which means within the class, you can access it without using the
            // class name and outside the class, you can access it without needing an instance of the class by using the class name.
            const float PI = 3.142f;
            Console.WriteLine(PI);
            //PI = 3.155; // error
            Console.WriteLine(x); // No need for class name or instance of the class as it is static by default.

            // READ ONLY
            // =========
            // When we declare a variable using the readonly keyword, then it is known as a `readonly` variable and these can't
            // be modified once initialized (similar to const)
            // It is not mandatory to initialize a readonly variable at the time of its declaration, but once we do so later, we cannot change
            // its value
            // It's behavior is similar to the behavior of non-static variables, meaning within the same class, we should use the class name
            // to access it or outside the class, we need an instance of the class.
            // The only places you can initialize a readonly variable is:
            //      - At the time of its creation
            //      - Inside a constructor
            ReadOnlySample s = new ReadOnlySample(900);
            Console.WriteLine(s.x);
            Console.WriteLine(s.y);
        }
    }

    class ReadOnlySample
    {
        // We can either initialize a readonly variable at the time of its creation
        public readonly int x = 99;
        
        // Or inside of a constructor and nowhere else
        public readonly int y;
        public ReadOnlySample(int yv)
        {
            y = yv;
        }
    }
}
