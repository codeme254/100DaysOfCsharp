using System;

namespace TryCatch
{
    internal class InnerException
    {
        static void Main(string[] args)
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
                    throw new Exception("Divisor cannot be an odd number");
                }
                Result = Number1 / Number2;
                Console.WriteLine($"{Number1} / {Number2} = {Result}");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Something went wrong...");
                Console.WriteLine(ex.Message);

                try
                {
                    throw new Exception("Some exception", ex);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException);
                }
            }
        }
    }
}
