// Implementing Encapsulation Through Properties
using System;


namespace EncapsulationUsingProperties
{
    class Bank
    {
        private double _Amount;
        public double Amount
        {
            get
            {
                return _Amount;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid Amount");
                    return;
                }
                _Amount = value;
            }
        }
    }
    internal class EncapsulationUsingProperties
    {
        //public static void Main(string[] args)
        //{
        //    Bank b = new Bank();
        //    Console.WriteLine(b.Amount);
        //    b.Amount = 9000;
        //    Console.WriteLine(b.Amount); // 9000
        //    b.Amount = -5000; // Invalid Amount
        //    Console.WriteLine(b.Amount); // 9000
        //}
    }
}
