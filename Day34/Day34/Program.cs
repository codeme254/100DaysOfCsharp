using System;
using System.Collections;

namespace QueueCollection
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue(101);
            q.Enqueue("Hello");
            q.Enqueue(3.142f);
            q.Enqueue(false);
            q.Enqueue('A');

            //q.Dequeue();
            //q.Dequeue();

            Console.WriteLine($"First element: {q.Dequeue()}"); // 101
            Console.WriteLine($"First element: {q.Peek()}"); // "Hello"

            Console.WriteLine(q.Contains("Hello")); // True
            Console.WriteLine(q.Contains("World")); // False

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
