using System;

namespace TryCatch
{
    public class OddNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "Divisor cannot be an odd number";
            }
        }

        public override string HelpLink
        {
            get
            {
                return "Learn more about odd number: https://en.wikipedia.org/wiki/Parity_(mathematics)";
            }
        }
    }
    internal class CustomException
    {
        static void Main1(string[] args)
        {
            int Number1, Number2, Result;
            try
            {
                Console.Write("Enter the first number: ");
                Number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the first number: ");
                Number2 = Convert.ToInt32(Console.ReadLine());

                if (Number2 % 2 != 0)
                {
                    throw new OddNumberException();
                }
                Result = Number1 / Number2;
                Console.WriteLine($"{Number1} / {Number2} = {Result}");
            } 
            catch(OddNumberException one)
            {
                Console.WriteLine(one.Message);
                Console.WriteLine(one.HelpLink);
            }
            // generic catch block - good practice to always have it
            catch(Exception ex)
            {
                Console.WriteLine("Something went wrong...");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
