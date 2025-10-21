using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Byte data type
            byte b1 = 55;
            Console.WriteLine(b1);
            Console.WriteLine($"ASCII equivalent of {b1} is {(char)b1}");

            Console.WriteLine($"Byte max value {byte.MaxValue}");
            Console.WriteLine($"Byte min value {byte.MinValue}");

            // sbyte data type
            sbyte b2 = -50;
            Console.WriteLine((char)b2);
            Console.WriteLine($"SByte max value {sbyte.MaxValue}");
            Console.WriteLine($"SByte min value {sbyte.MinValue}");

            // Char data type
            char studentGrade = 'A';
            Console.WriteLine(studentGrade);
            Console.WriteLine($"Char max value {char.MaxValue}");
            Console.WriteLine($"Char min value {char.MinValue}");

            // String data type
            string firstName = "John";
            string lastName = "Doe";
            Console.WriteLine($"{firstName} {lastName}");

            // boolean
            Boolean isMale = true;
            Console.WriteLine(isMale);

            // Int16
            Int16 myNum = 30000;
            Console.WriteLine(myNum);
            Console.WriteLine($"Int16 max value: {Int16.MaxValue}");
            Console.WriteLine($"Int16 min value: {Int16.MinValue}");

            // Int32
            Int32 myNum2 = 2_000_000;
            Console.WriteLine(myNum2);
            Console.WriteLine($"Int32 max value: {Int32.MaxValue}");
            Console.WriteLine($"Int32 min value: {Int32.MinValue}");

            // Int64
            Int64 myNum3 = 2_000_000_000;
            Console.WriteLine(myNum3);
            Console.WriteLine($"Int64 max value: {Int64.MaxValue}");
            Console.WriteLine($"Int64 min value: {Int64.MinValue}");

            Console.WriteLine($"UInt16 max value: {UInt16.MaxValue}");
            Console.WriteLine($"UInt16 min value: {UInt16.MinValue}");
            Console.WriteLine($"ushort max value: {ushort.MaxValue}");
            Console.WriteLine($"ushort min value: {ushort.MinValue}");

            Console.WriteLine($"UInt32 max value: {UInt32.MaxValue}");
            Console.WriteLine($"UInt32 min value: {UInt32.MinValue}");
            Console.WriteLine($"uint max value: {uint.MaxValue}");
            Console.WriteLine($"uint min value: {uint.MinValue}");

            Console.WriteLine($"UInt64 max value: {UInt64.MaxValue}");
            Console.WriteLine($"UInt64 min value: {UInt64.MinValue}");
            Console.WriteLine($"ulong max value: {ulong.MaxValue}");
            Console.WriteLine($"ulong min value: {ulong.MinValue}");

            Single myVal = 10.234F;
            Console.WriteLine(myVal);
            Console.WriteLine($"Single max value: {Single.MaxValue}");
            Console.WriteLine($"Single min value: {Single.MinValue}");

            Double myVal2 = 4323.242342;
            Console.WriteLine(myVal2);
            Console.WriteLine($"Double max value: {Double.MaxValue}");
            Console.WriteLine($"Double min value: {Double.MinValue}");

            Decimal myVal3 = 92342897.243141M;
            Console.WriteLine(myVal3);
            Console.WriteLine($"Decimal max value: {Decimal.MaxValue}");
            Console.WriteLine($"Decimal min value: {Decimal.MinValue}");

            // sizes of data types
            Console.WriteLine($"Size of int {sizeof(int)}");
            Console.WriteLine($"Size of decimal {sizeof(decimal)}");
            Console.WriteLine($"Size of byte {sizeof(byte)}");
            Console.WriteLine($"Size of sbyte {sizeof(sbyte)}");

        }
    }
}
