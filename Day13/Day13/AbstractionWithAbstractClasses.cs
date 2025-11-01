using System;

namespace AbstractionWithAbstractClasses
{
    abstract class IBank
    {
        public abstract void WithdrawMoney();
        public abstract void CheckBalance();
    }

    class Bank : IBank
    {
        public override void WithdrawMoney()
        {
            Console.WriteLine("Withraw cash");
        }

        public override void CheckBalance()
        {
            Console.WriteLine("Check balance");
        }

        public void AnotherBankMethod()
        {
            Console.WriteLine("Another bank method");
        }
    }
    internal class AbstractionWithAbstractClasses
    {
        public static void Main(string[] args)
        {
            IBank b = new Bank();
            b.CheckBalance();
            b.CheckBalance();
            //b.AnotherBankMethod(); // Error
        }
    }
}
