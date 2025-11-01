using System;

namespace AbstractionWithInterface
{
    interface IBank
    {
        void ValidateCard();
        void WithdrawCash();
        void CheckBalance();
        void BankTransfer();
        void MiniStatement();
    }

    class Bank: IBank
    {
        public void ValidateCard()
        {
            Console.WriteLine("Card vaildation");
        }
        public void WithdrawCash()
        {
            Console.WriteLine("Withdraw cash");
        }

        public void CheckBalance()
        {
            Console.WriteLine("Check balance");
        }

        public void BankTransfer()
        {
            Console.WriteLine("Bank transfer");
        }

        public void MiniStatement()
        {
            Console.WriteLine("Mini Statement");
        }

        public void AnotherBankMethod()
        {
            Console.WriteLine("Another bank method");
        }
    }
    internal class AbstractionWithInterface
    {
        //public static void Main(string[] args)
        //{
        //    IBank b = new Bank();
        //    b.BankTransfer();
        //    b.ValidateCard();
        //    //b.AnotherBankMethod(); // Error
        //}
    }
}
