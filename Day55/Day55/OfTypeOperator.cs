using System;
using System.Collections.Generic;
using System.Linq;

namespace Day55
{
    class OfTypeOperator
    {
        static void Main1(string[] args)
        {
            List<object> myList = new List<object>()
            {
                "Hello", 21, 92, 44, 81, "world", 55.5, 98.2f, 800, "Jane"
            };

            // Method Syntax
            IEnumerable<int> integers = myList.OfType<int>();

            foreach(int i in integers)
            {
                Console.WriteLine(i);
            }

            // Query Syntax
            IEnumerable<int> integers2 = from obj in myList.OfType<int>()
                                         select obj;
            foreach(int i in integers2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
