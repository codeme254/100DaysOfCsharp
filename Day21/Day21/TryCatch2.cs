using System;

namespace TryCatch
{
    internal class TryCatch2
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
            catch (Exception e)
            {
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Source: {e.Source}");
                Console.WriteLine($"HelpLink: {e.HelpLink}");
                Console.WriteLine($"StackTrace: {e.StackTrace}");
            }
        }
    }
}
