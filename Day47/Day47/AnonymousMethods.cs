using System;

namespace DelegatesReview
{
    internal class AnonymousMethods
    {
        delegate void AddNumbers(int num1, int num2);

        static void Main(string[] args)
        {
            AddNumbers del = delegate (int num1, int num2)
            {
                if (num1 > num2)
                {
                    Console.WriteLine($"{num1} is greater than {num2}");
                    Console.WriteLine($"But the sum of {num1} and {num2} is {num1 + num2}");
                } 
                else if (num1 < num2)
                {
                    Console.WriteLine($"{num1} is less than {num2}");
                    Console.WriteLine($"But who cares, the sum of {num1} and {num2} is {num1 + num2}");
                } 
                else
                {
                    Console.WriteLine($"Great, the two numbers are equal");
                    Console.WriteLine($"But their summation is {num1 + num2}");
                }
            };

            del(10, 20);
            del(30, 15);
            del(5, 5);
        }
    }
}
