using Microsoft.SqlServer.Server;
using System;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Decimal literal
            // allowed digits are 0 to 9
            // No prefix or suffix is required
            int decimalNumber = 210;
            Console.WriteLine($"Decimal literal: {decimalNumber}");

            // Hexadecimal literal
            // allowed digits are 0 to 9 and characters a to f
            // prefix with 0x or 0X and suffix with f or F (not case sensitive)
            int hexadecimalNumber = 0x372F;
            Console.WriteLine($"Hexadecimal literal: {hexadecimalNumber}");

            // Binary literal
            // allowed digits are 0 and 1 only.
            // prefix with 0b
            int binaryNumber = 0b110111;
            Console.WriteLine($"Binary literal: {binaryNumber}");

            // Double literal
            // No suffix is required but you can suffix with D or d
            double myDouble = 99.25D;
            double myDouble2 = 88.92;
            Console.WriteLine($"{myDouble} {myDouble2}");

            // Float literal
            // Suffix with f or F
            float myFloat = 12.3f;
            Console.WriteLine(myFloat);

            // Decimal literal
            // Suffix with d or D
            decimal myDecimal = 12.3M;
            Console.WriteLine(myDecimal);

            // character literals using a single quote
            char ch = 'A';
            Console.WriteLine(ch);

            // character literals using unicode representation
            char ch2 = '\u0041';
            Console.WriteLine(ch2);

            // character literals using escape characters
            char ch3 = '\t';
            Console.WriteLine(ch3);

            // Regular String literal
            string s1 = "Hello, World!";
            Console.WriteLine(s1);

            // Verbatim String literal
            string s2 = @"This is cool\n";
            Console.WriteLine(s2);

            // boolean literals - true or false
            bool b1 = true;
            bool b2 = false;
            Console.WriteLine($"{b1} {b2}");

            int numInt = 1500;
            double numDouble = numInt;

            // Values before conversion
            Console.WriteLine($"numInt value {numInt}");
            Console.WriteLine($"numInt type {numInt.GetType()}");
            Console.WriteLine($"Int size: {sizeof(int)}");

            // Values after conversion
            Console.WriteLine($"numDouble value {numDouble}");
            Console.WriteLine($"numDouble type {numDouble.GetType()}");
            Console.WriteLine($"double size {sizeof(double)}");

            double myDoubleNum = 1.23;
            int myIntNum = (int)myDoubleNum;
            Console.WriteLine($"Original double value: {myDoubleNum}");
            Console.WriteLine($"Converted int value: {myIntNum}");

            string str = "100";
            int i1 = Convert.ToInt32(str);
            Console.WriteLine(i1);

            float f = 123.45F;
            string str2 = Convert.ToString(f);
            Console.WriteLine(str2);

            string myString = "9278";
            int myInt = int.Parse(myString);
            Console.WriteLine(myInt);

            string myString2 = "TRUE";
            bool b = bool.Parse(myString2);
            Console.WriteLine(b);

            string awesomeString = "92834";
            bool isConverted = int.TryParse(awesomeString, out int myAwesomeInt);
            Console.WriteLine(isConverted); // True
            Console.WriteLine(myAwesomeInt); // 92834

            string anotherAwesomeString = "Hello, World!";
            isConverted = int.TryParse(anotherAwesomeString, out int anotherInt);
            Console.WriteLine(isConverted); // False
            Console.WriteLine(anotherInt); // 0
        }
    }
}
