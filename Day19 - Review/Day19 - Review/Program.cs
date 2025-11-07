using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            // Byte - represents 8-bit unsigned integers (only positive values)
            // 8-bit - meaning it can store 2^8 possible numbers - 256 numbers
            // These numbers are 0 to 255
            // ASCII characters map neatly to that 0 - 127 range thus we can use bytes to store ascii values
            byte b1 = 69;
            Console.WriteLine(b1);
            Console.WriteLine($"Ascii equivalent of {b1} is {(char)b1}");
            Console.WriteLine($"byte max value is {byte.MaxValue}");
            Console.WriteLine($"byte min value is {byte.MinValue}");

            // sbyte - 8-bit unsigned intenger (both positive and negative numbers0
            // 8-bit - meaning it can store 2^8 possible numbers - 256 numbers
            // Min value is -128 and max value is 127
            sbyte b2 = 69;
            Console.WriteLine(b2);
            Console.WriteLine($"sbyte max value is {sbyte.MaxValue}");
            Console.WriteLine($"sbyte min value is {sbyte.MinValue}");

            // char - represents characters
            char c1 = 'a';
            Console.WriteLine(c1);
            // we can also store unicode values in char
            char c2 = '\u0061';
            Console.WriteLine(c2);

            // String - series of characters enclosed within double quotes
            string username = "John";
            Console.WriteLine($"Username is {username}");

            // Boolean - only true or false values
            bool x = true;
            Console.WriteLine(x);

            // INTEGER TYPES
            // =============

            // Integer types are divided into 3 as follows
            // 16-bit signed: Int16 or short
            // 32-bit signed: Int32 or int
            // 64-bit signed: Int64 or long

            // Unsigned versions of the above
            // UInt16 or ushort
            // UInt32 or uint
            // UInt64 or ulong
            //short a = 55;
            //short na = -55;
            //int b = 99;
            //int nb = -99;
            //long c = 200;
            //long nc = -200;

            //ushort ua = 200;
            //uint ub = 900;
            //ulong uc = 500;

            Console.WriteLine($"short max value: {short.MaxValue}");
            Console.WriteLine($"short min value: {short.MinValue}");
            Console.WriteLine($"int min value: {int.MinValue}");
            Console.WriteLine($"int max value: {int.MaxValue}");
            Console.WriteLine($"long min value: {long.MinValue}");
            Console.WriteLine($"long max value: {long.MaxValue}");

            Console.WriteLine($"ushort min value: {ushort.MinValue}");
            Console.WriteLine($"ushort max value: {ushort.MaxValue}");
            Console.WriteLine($"uint min value: {uint.MinValue}");
            Console.WriteLine($"uint max value: {uint.MaxValue}");
            Console.WriteLine($"ulong min value: {ulong.MinValue}");
            Console.WriteLine($"ulong max value: {ulong.MaxValue}");

            // DECIMAL TYPES
            // =============
            // Store numbers with decimal points
            // float/Single: suffix number with f
            // decimal/Decimal: suffix number with m
            // double/Double: no suffixes needed
            float f1 = 33.5f;
            Console.WriteLine(f1);
            decimal d1 = 33.6m;
            Console.WriteLine(d1);
            double d2 = 99.9;
            Console.WriteLine(d2);

            // GETTING THE SIZE OF BUILT-IN DATA TYPES
            // =======================================
            // use the sizeof() operator which returns the size of a data type in bytes
            Console.WriteLine($"Size of int is {sizeof(int)} bytes");
            Console.WriteLine($"Size of decimal is {sizeof(decimal)} bytes");
            Console.WriteLine($"Size of char is {sizeof(char)} bytes");
            Console.WriteLine($"Size of double is {sizeof(double)} bytes");

            // ASCII TABLE
            //for (int i = 0; i <= 127; i++)
            //{
            //    Console.WriteLine($"ASCII equivalent of {i} is {(char)i}");
            //}
        }
    }
}
