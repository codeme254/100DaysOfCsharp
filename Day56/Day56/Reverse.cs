using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseMethod
{
    internal class ReverseMethod
    {
        static void Main(string[] args)
        {
            List<char> charList = new List<char>()
            {
                'd', 'l', 'r', '0', 'w', ' ', 'o', 'l', 'l', 'e', 'h'
            };

            // Method Syntax
            //IEnumerable<char> reversed1 = charList.Reverse();
            IEnumerable<char> reversed1 = Enumerable.Reverse(charList);
            foreach(char c in reversed1)
            {
                Console.WriteLine(c);
            }
        }
    }
}