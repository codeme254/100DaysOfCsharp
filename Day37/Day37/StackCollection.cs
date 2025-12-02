using System;
using System.Collections.Generic;

namespace StackCollection
{
    internal class StackCollection
    {
        static void Main1(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            //stack.Pop();
            //stack.Clear();
            //Console.WriteLine(stack.Peek()); // 50
            Console.WriteLine(stack.Contains(90));// False
            Console.WriteLine(stack.Contains(40)); // True

            foreach(int item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
