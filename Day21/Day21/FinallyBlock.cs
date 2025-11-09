using System;

namespace TryCatch
{
    internal class FinallyBlock
    {
        static void Main1(string[] args)
        {
            int Number1, Number2, Result;
            try
            {
                Console.Write("Enter the first number: ");
                Number1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter the second number: ");
                Number2 = Convert.ToInt16(Console.ReadLine());
                Result = Number1 / Number2;
                Console.WriteLine($"Result = {Result}");
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine("Second number should not be zero");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Only integer numbers allowed");
            }
            finally
            {
                Console.WriteLine("This is the finally block");
            }
        }
    }
}
