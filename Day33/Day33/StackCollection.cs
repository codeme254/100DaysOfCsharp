using System;
using System.Collections;

namespace StackCollection
{
    internal class StackCollection
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("John");
            stack.Push(10);
            stack.Push(3.14f);
            stack.Push("Hello");
            stack.Push("A");
            stack.Push(true);
            stack.Push(false);

            Console.WriteLine(stack.Peek()); // False

            stack.Pop();
            stack.Pop();

            // You can also remove all items using the Clear method
            //stack.Clear();

            Console.WriteLine(stack.Contains("Hello")); // True
            Console.WriteLine(stack.Contains("World")); // False

            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
