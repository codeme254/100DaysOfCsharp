using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SortedDictionaryCollection
{
    internal class SortedDictionaryCollection
    {
        static void Main1(string[] args)
        {
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
            sd.Add(1, "One");
            sd.Add(2, "Two");
            sd.Add(10, "Ten");
            sd.Add(3, "Three");
            sd.Add(5, "Five");
            sd.Add(7, "Seven");

            sd[4] = "Four";
            sd[6] = "Six";
            sd[8] = "Eight";
            sd[9] = "Nine";

            sd[8] = "New Eight";
            sd[5] = "New Five";

            //Console.WriteLine(sd[2]); // Two
            //Console.WriteLine(sd[10]); // Ten
            //Console.WriteLine(sd[7]); // Seven

            //sd.Remove(10);
            //sd.Remove(5);
            //sd.Remove(7);

            //sd.Clear();

            //Console.WriteLine(sd.ContainsKey(10)); // True
            //Console.WriteLine(sd.ContainsKey(1000)); // False

            //Console.WriteLine(sd.ContainsValue("Three")); // True
            //Console.WriteLine(sd.ContainsValue("Nine")); // False

            bool tenExists = sd.TryGetValue(10, out string ten);
            if (tenExists)
            {
                Console.WriteLine(ten);
            }
            else
            {
                Console.WriteLine("Value does not exist");
            }

            bool twentyExists = sd.TryGetValue(20, out string twenty);
            if (twentyExists)
            {
                Console.WriteLine(twenty);
            }
            else
            {
                Console.WriteLine("Twenty does not exist");
            }

                foreach (KeyValuePair<int, string> kvp in sd)
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                }


            Console.WriteLine("===KEYS===");
            foreach(int key in sd.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("===VALUES===");
            foreach(string value in sd.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
