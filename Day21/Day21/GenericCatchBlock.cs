using System;

namespace TryCatch
{
    internal class GenericCatchBlock
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
            catch(Exception ex )
            {
                Console.WriteLine("Something went wrong");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
