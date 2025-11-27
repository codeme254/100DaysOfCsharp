using System;
using System.Collections;

namespace SortedListCollection
{
    internal class SortedListCollection
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add(1, "One");
            sl.Add(2, "Two");
            sl.Add(3, "Three");
            sl.Add(50, 5);
            sl.Add(100, null);

            //Console.WriteLine($"Key 100, value {sl[100]}"); // null
            //Console.WriteLine($"Key 50, value {sl[50]}"); // 5
            //Console.WriteLine($"Key 1, value {sl[1]}");  // One

            //Console.WriteLine(sl.GetByIndex(0)); // One
            //Console.WriteLine(sl.GetByIndex(1)); // Two
            //Console.WriteLine(sl.GetByIndex(3)); // 5

            //for (int i = 0; i < sl.Count; i++)
            //{
            //    Console.WriteLine("---");
            //    Console.WriteLine($"Key: {sl.GetKey(i)}");
            //    Console.WriteLine($"Value: {sl.GetByIndex(i)}");
            //    Console.WriteLine("---");
            //}

            //foreach(DictionaryEntry item in sl)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //}

            SortedList sortedList = new SortedList()
            {
                {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4}
            };
            //sortedList.Remove("two");
            //sortedList.RemoveAt(2);
            Console.WriteLine(sortedList.Contains("one")); // True
            Console.WriteLine(sortedList.ContainsKey("two")); // True
            Console.WriteLine(sortedList.ContainsKey("hello")); // False
            Console.WriteLine(sortedList.ContainsValue(500)); // False
            Console.WriteLine(sortedList.ContainsValue(4)); // True
            Console.WriteLine(sortedList.ContainsValue("hello world")); // False
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
    }
}
