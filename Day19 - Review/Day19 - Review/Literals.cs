using System;

namespace Literals
{
    internal class Literals
    {
        static void Main(string[] args)
        {
            // INTEGER LITERALS
            // ================
            // We can represent integer literals in terms of Decimal, Binary or Hexadecimal
            // Binary - prefix with 0b
            // Hexadecimal - prefix with 0X
            // Decimal - no prefix required

            // Decimal - base 10, no prefix required, values 0-9
            int x = 209;
            Console.WriteLine(x);
            // Hexadecimal - digits 0 to 9 and characters a to f, prefix with 0X
            int y = 0x99D;
            Console.WriteLine(y);
            // Binary - only 0 and 1 are allowed, prefix with 0b
            int z = 0b011100111;
            Console.WriteLine(z);

            // FLOATING POINT LITERALS
            // =======================
            // decimal - suffix with m or M
            // float - suffix with f or F
            // double - no suffix needed but you can suffix with d or D
            decimal d1 = 99.99m;
            Console.WriteLine(d1);
            float f1 = 88.88f;
            Console.WriteLine(f1);
            double d2 = 77.77d;
            Console.WriteLine(d2);

            // CHARACTER LITERALS
            // ==================
            // wrap within single quotes - 'A'
            // every escape character can be specified as a character literal - '\n', '\t'
            // we can represent character literals using unicode - '\uxxxx', where xxxx is the
            //     4 hexadecimal numbers for example '\u0041'
            char c1 = 'a';
            Console.WriteLine(c1);
            char c2 = '\n';
            Console.WriteLine(c2);
            char c3 = '\u0041';
            Console.WriteLine(c3);

            // STRING LITERALS
            // ===============
            // regular string literals - enclosed within double quotes
            // verbatim string literals - starts with @ followed by double quotes.
            // verbatim string literals can store escape sequence which is printed in the output
            string s1 = "Hello \n World";
            Console.WriteLine(s1);
            string s2 = @"Hello \n World";
            Console.WriteLine(s2);

            // BOOLEAN LITERALS
            // ================
            // Store either true or false
            bool b1 = true;
            Console.WriteLine(b1);
            bool b2 = false;
            Console.WriteLine(b2);
        }
    }
}
