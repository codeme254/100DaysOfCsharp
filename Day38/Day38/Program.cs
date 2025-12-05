using System;
using System.Collections.Generic;

namespace SortedSetCollection
{
    internal class Program
    {
        static void Main1(string[]args)
        {
            //SortedSet<int> st = new SortedSet<int>();
            //st.Add(10);
            //st.Add(5);
            //st.Add(60);
            //st.Add(70);
            //st.Add(25);
            //st.Add(60);

            ////st.Remove(10);
            ////st.Remove(5);

            ////st.RemoveWhere(num => num < 20);

            ////st.Clear();
            //Console.WriteLine(st.Contains(10)); // True
            //Console.WriteLine(st.Contains(100)); // False

            //foreach (int i in st)
            //{
            //    Console.WriteLine(i);
            //}

            SortedSet<int> set1 = new SortedSet<int>()
            {
                1, 2, 3, 4
            };
            SortedSet<int> set2 = new SortedSet<int>()
            {
                3, 4, 5, 6
            };

            //set1.UnionWith(set2);
            //set1.IntersectWith(set2);
            //set1.ExceptWith(set2);
            set1.SymmetricExceptWith(set2);

            foreach (int i in set1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
