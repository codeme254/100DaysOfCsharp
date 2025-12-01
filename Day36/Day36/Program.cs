using System;
using System.Collections.Generic;

namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> countries = new List<string>();
            countries.Add("Germany");
            countries.Add("France");
            countries.Add("Kenya");
            countries.Add("Russia");
            countries.Add("India");
            countries.Add("Indonesia");

            //countries.Insert(0, "Croatia");
            //countries.Insert(3, "Morocco");
            //countries.Insert(4, "USA");

            Console.WriteLine(countries.Contains("Germany")); // True
            Console.WriteLine(countries.Contains("Monnaco")); // False

            //countries.Remove("France");
            //countries.Remove("Russia");

            //countries.RemoveAt(0);
            //countries.RemoveAt(3);

            // Remove 3 elements starting from index 0
            //countries.RemoveRange(0, 3);

            // Remove all countries whose length is less than 7
            //countries.RemoveAll(countryName => countryName.Length < 7);

            //countries.Clear();
            //string country = countries.Find(countryName => countryName[0] == 'I');
            //Console.WriteLine(country); // India

            //string country = countries.FindLast(countryName => countryName[0] == 'I');
            //Console.WriteLine(country); // Indonesia

            //List<string> result = countries.FindAll(country => country[0] == 'I');
            //foreach(string country in result)
            //{
            //    Console.WriteLine(country);
            //}

            //int idx = countries.FindIndex(c => c[0] == 'I');
            //Console.WriteLine(idx); // 4

            //int idx = countries.FindLastIndex(c => c[0] == 'I');
            //Console.WriteLine(idx); // 5

            bool exists = countries.Exists(c => c.Length > 10);
            Console.WriteLine(exists); // False

            //foreach(string country in countries)
            //{
            //    Console.WriteLine(country);
            //}
        }
    }
}
