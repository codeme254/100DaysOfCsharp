using System;

namespace TypeConversion
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            // Type Conversion can be classified into two:
            //      - Implicit type conversion/casting
            //      - Expicit type conversion/casting

            // IMPLICIT TYPE CONVERSION
            // ========================
            // Done by the compiler and there's no data loss
            // Done from a smaller data type to a larger data type
            // Compiler will automatically convert one type to another
            // Smaller data types like int having less memory size are automatically converted to larger data types like long (having larger memory size).
            int myInt = 500;
            double myDouble = myInt; // Compiler will automatically convert int type value to double type
            Console.WriteLine(myDouble);
            // Conversion is possible because they are both numeric types
            // Also double is larger than int (8 bytes vs 4 bytes) - no issue storing 4 bytes of data inside 8-bytes of memory location.

            // EXPLICIT TYPE CONVERSION
            // ========================
            // When you want to convert a larger data type to a smaller data type, then you need to do this explicitly.
            // Done using the cast operator - (int) something
            // There is a chance of data loss or the conversion might fail for some reason
            double d = 59.555;
            int i = (int)d;
            Console.WriteLine(i); // 59 - some data has been lost
            // We don't always lose data in the case of explicit conversion, data loss depends on the value we are converting.
            int x = 200;
            byte y = (byte)x;
            Console.WriteLine(y); // 100 - no data has been lost

            // CONVERSION WITH HELPER METHODS
            // ==============================
            // for conversion betwen non-compatible types like integer and string, .NET provides us with the following:
            // - Convert class
            // - Parse method
            // - TryParse method

            // CONVERT CLASS HELPER METHODS
            // ============================
            // Example, if you want to convert string to int, you can use Convert.ToInt16 - int, Convert.ToInt32 - short, Convert.ToInt64 - long 
            string str1 = "2909918788";
            long l1 = Convert.ToInt64(str1);
            Console.WriteLine(l1);

            // Parse() METHOD
            // ==============
            // We can use the built-in Parse() method to perform type conversion
            string str2 = "2909918788";
            long l2 = long.Parse(str2);
            Console.WriteLine(l2);

            // TryParse() METHOD
            // =================
            // Converts a value to another type and if successful it does two things:
            //      - Stores the converted value to a variable we have supplied as the second parameter `out type var_name`
            //      - return true
            // If the conversion fails, it returns false
            string str3 = "2909918788";
            bool isConverted = long.TryParse(str3, out long l3);
            if (isConverted)
            {
                Console.WriteLine($"Conversion was successfull {l3}");
            } else
            {
                Console.WriteLine("Conversion failed");
            }
        }
    }
}
