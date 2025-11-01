using System;

namespace Encapsulation
{
    class Bank
    {
        // Hiding data by declaring the variable as private
        private double balance;

        // Getter method
        // This method returns the data stored in balance variable
        public double GetBalance()
        {
            return balance;
        }

        // Setter method
        // This method is used to store data in the balance variable
        public void SetBalance(double val)
        {
            if (val < 0)
            {
                Console.WriteLine("Invalid Amount"); ;
                return;
            }
            balance = val;
        }
    }
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Bank bank = new Bank();
        //    //Console.WriteLine(bank.balance); // Compile Time Error
            
        //    // You need to access the balance using provided getters and setters
        //    bank.GetBalance();
        //    bank.SetBalance(9000);
        //    Console.WriteLine(bank.GetBalance());
        //    bank.SetBalance(-5000); // Invalid Amount
        //    Console.WriteLine(bank.GetBalance()); // Still 9000
        //}
    }
}
