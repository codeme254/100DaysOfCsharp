using System;
using System.Collections;

namespace ArrayListClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList()
            {
                102, "Jane", 99.448, true, false, null
            };

            foreach(var item in arraylist)
            {
                Console.WriteLine(item);
            }

            ArrayList myList = new ArrayList();
            myList.Add(101);
            myList.Add("Jane");
            myList.Add("June");
            myList.Add(true);
            myList.Add(false);
            myList.Add(4.555);

            foreach(var item in myList)
            {
                Console.WriteLine(item);
            }

            int firstItem = (int)myList[0];
            string secondItem = (string)myList[1];
            // no need for casting when using the var keyword
            var thirditem = myList[2];
            var fourthItem = myList[3];
            Console.WriteLine($"{firstItem}, {secondItem}, {thirditem}, {fourthItem}");

            Console.WriteLine(myList.Count);


            var lst = new ArrayList()
            {
                101, 102, "John", "Ann", true
            };
            lst.Insert(0, "First Element");
            lst.Insert(2, "Third Element");

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            ArrayList lst1 = new ArrayList() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array List Elements Before");
            foreach(var item in lst1)
            {
                Console.WriteLine(item);
            }

            ArrayList lst2 = new ArrayList() { 6, 7, 8, 9, 10 };
            lst1.InsertRange(5, lst2);

            Console.WriteLine("Array List Elements After");
            foreach(var item in lst1)
            {
                Console.WriteLine(item);
            }

            ArrayList countries = new ArrayList()
            {
                "USA", "Kenya", "India", "Morocco", "Libya", "UK", "China", "USA"
            };

            //Console.WriteLine(countries.Capacity);
            //Console.WriteLine(countries.Count);
            //countries.Clear();
            //Console.WriteLine("After Clearing");
            //Console.WriteLine(countries.Capacity);
            //Console.WriteLine(countries.Count);

            // Remove the first occurence of an element
            countries.Remove("USA");
            foreach(var country in countries)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine();

            // Remove an item at a specific index
            countries.RemoveAt(2);
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine();

            // Remove a range of elements
            countries.RemoveRange(3, 2);
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            Console.WriteLine($"{countries.Contains("Kenya")}"); // true
            Console.WriteLine($"{countries.Contains("Monnaco")}"); // false
        }
    }
}
