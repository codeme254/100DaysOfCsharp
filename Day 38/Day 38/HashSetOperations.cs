using System;
using System.Collections.Generic;

namespace HashSetOperations
{
    internal class HashSetOperations
    {
        static void Main1(string[] args)
        {
            HashSet<int> ints1 = new HashSet<int>()
            {
                1, 2, 3, 4
            };

            HashSet<int> ints2 = new HashSet<int>()
            {
                3, 4, 5, 6
            };

            //ints1.UnionWith(ints2);
            //ints1.IntersectWith(ints2);
            //ints1.ExceptWith(ints2);
            ints1.SymmetricExceptWith(ints2);

            foreach(int i in ints1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
