using System;
using System.Collections.Generic;

namespace DictionaryCollection
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("One", 1);
            dict.Add("Two", 2);
            dict.Add("Three", 3);
            dict.Add("Four", 4);
            dict.Add("Five", 5);

            // Adding elements using indexer
            //dict["six"] = 6;
            //dict["seven"] = 7;
            //dict["eight"] = 8;

            // Updating elements using indexer
            dict["One"] = 11;
            dict["Two"] = 22;
            dict["Three"] = dict["Three"] * 11;
            dict["Four"] = dict["Four"] * 11;
            dict["Five"] = dict["Five"];

            //Console.WriteLine(dict["One"]); // 1
            //Console.WriteLine(dict["Two"]); // 2

            //Console.WriteLine(dict.ContainsKey("One")); // True
            //Console.WriteLine(dict.ContainsKey("Ten")); // False
            //Console.WriteLine(dict.ContainsValue(1)); // True
            //Console.WriteLine(dict.ContainsValue(9)); // False

            if (dict.ContainsKey("One"))
            {
                dict.Remove("One");
            }

            //dict.Clear();

            foreach(KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"Key: {kvp.Key}, value: {kvp.Value}");
            }

            bool nineExists = dict.TryGetValue("Nine", out int nineVal);
            if (nineExists)
            {
                Console.WriteLine(nineVal);
            }
            else
            {
                Console.WriteLine("Nine doesn't exist");
            }

            Console.WriteLine("===KEYS===");
            foreach(string key in dict.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("===VALUES===");
            foreach(int value in dict.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
