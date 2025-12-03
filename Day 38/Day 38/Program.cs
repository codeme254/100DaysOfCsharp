using System;
using System.Collections.Generic;

namespace HashsetCollection
{
    internal class Program
    {
        static void Main1s(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("India");
            set.Add("Canada");
            set.Add("USA");
            set.Add("Morocco");
            set.Add("Kenya");
            set.Add("India");

            //set.Remove("Morocco");
            //set.Remove("Canada");

            //set.RemoveWhere(country => country.Length < 7);

            //set.Clear();

            Console.WriteLine(set.Contains("India")); // True
            Console.WriteLine(set.Contains("China")); // False

            foreach(string country in set)
            {
                Console.WriteLine(country);
            }
        }
    }
}
