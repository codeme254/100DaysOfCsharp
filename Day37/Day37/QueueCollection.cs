using System;
using System.Collections.Generic;

namespace QueueCollection
{
    internal class QueueCollection
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            //queue.Dequeue();
            //queue.Clear();

            Console.WriteLine(queue.Peek());

            Console.WriteLine(queue.Contains(90)); // False
            Console.WriteLine(queue.Contains(40)); // True

            foreach(int item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
