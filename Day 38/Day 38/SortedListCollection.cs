using System;
using System.Collections.Generic;

namespace SortedListCollection
{
    internal class SortedListCollection
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();

            sl.Add(1, "One");
            sl.Add(5, "Five");
            sl.Add(3, "Three");
            sl.Add(2, "Two");
            sl.Add(4, "Four");

            ////Console.WriteLine(sl[0]); // Error, key 0 is not present
            //Console.WriteLine(sl[1]); // One
            //Console.WriteLine(sl[4]); // Four

            //// Adding new items
            //sl[9] = "Nine";

            //// Updating items
            //sl[4] = "new four";

            //sl.Remove(5);

            //sl.RemoveAt(0);
            //sl.Clear();

            Console.WriteLine(sl.ContainsKey(1)); // True
            Console.WriteLine(sl.ContainsKey(20)); // False

            Console.WriteLine(sl.ContainsValue("One")); // True
            Console.WriteLine(sl.ContainsValue("Fifty")); // False

            foreach(KeyValuePair<int, string> kv in sl)
            {
                Console.WriteLine($"Key: {kv.Key}, Value: {kv.Value}");
            }
        }
    }
}
