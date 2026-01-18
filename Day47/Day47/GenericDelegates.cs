using System;
using System.Runtime.InteropServices;

// C# Provides 3 generic delegates: Func, Action, Predicate
// All of these 3 generic delegattes are present in the system namespace

// Func: takes one or more input parameters and returns one out parameter, the last parameter is considered as the return value
// Func can take a max of 16 input parameters of different or same data types
// Must have one return type, the return type is mandatory but the input parameter is not mandatory
// WHENEVER YOUR DELEGATE RETURNS SOME VALUE, WHETHER BY TAKING ANY INPUT PARAMETER OR NOT, USE FUNC GENERIC DELEGATE

// Action: takes one or more input parameters and returns nothing.
// Action can take a max of 16 input parameters of the same or different data type
// WHENEVER YOUR DELEGATE DOES NOT RETURN ANY VALUE, WHETHER BY TAKING ANY INPUT PARAMETER OR NOT, USE ACTION GENERIC DELEGATE

// Predicate: used to verify certain criteria of the method and returns the output as boolean, either true or false.
// Predicate takes one input parameter and always returns a Boolean value which is mandatory.
// Max of one input parameter and returns a boolean
// Whenever your delegate returns a boolean value by taking only one input parameter, tthen you need to use the Predicate Generic Delegate

namespace DelegatesReview
{
    internal class GenericDelegates
    {
        static double AddNumbers(int num1, double num2, float num3)
        {
            return num1 + num2 + num3;
        }

        static void SumNumbers(int num1, double num2, float num3)
        {
            Console.WriteLine(num1 + num2 + num3);
        }

        static bool CheckLength(string name)
        {
            return name.Length >= 5;
        }

        static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }

        static void Main1(string[] args)
        {
            Func<int, double, float, double> del = new Func<int, double, float, double>(AddNumbers);
            Console.WriteLine(del.Invoke(10, 20, 30));

            Action<int, double, float> del2 = new Action<int, double, float>(SumNumbers);
            del2.Invoke(10, 20, 30);

            Predicate<string> del3 = new Predicate<string>(CheckLength);
            Console.WriteLine(CheckLength("Dennis"));
        }
    }
}
