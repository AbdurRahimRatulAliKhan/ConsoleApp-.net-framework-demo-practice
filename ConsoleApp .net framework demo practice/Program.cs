using ClassLibrary1;
using System;

namespace ConsoleApp.net_framework_demo_practice
{
    public abstract class IBank
    {
        public abstract void ValidateCard();
        public abstract void WithdrawMoney();
        public abstract void CheckBalance();
        public abstract void BankTransfer();
        public abstract void MiniStatement();

    }

    public class BankFactory
    {
        public static IBank GetBankObject(string bankType)
        {
            IBank BankObject = null;
            if(bankType == "SBI")
            {
                BankObject = new SBI();
            }
            else if (bankType == "AXIX")
            {
                BankObject = new AXIX();
            }
            return BankObject;
        }
    }
    public class SBI : IBank
    {
        public override void BankTransfer()
        {
            Console.WriteLine("SBI Bank Bank Transfer");
        }

        public override void CheckBalance()
        {
            Console.WriteLine("SBI Bank Check Balance");
        }

        public override void MiniStatement()
        {
            Console.WriteLine("SBI Bank Mini Statement");
        }

        public override void ValidateCard()
        {
            Console.WriteLine("SBI Bank Validate Card");
        }

        public override void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank Withdraw Money");
        }
    }

    public class AXIX : IBank
    {
        public override void BankTransfer()
        {
            Console.WriteLine("AXIX Bank Bank Transfer");
        }

        public override void CheckBalance()
        {
            Console.WriteLine("AXIX Bank Check Balance");
        }

        public override void MiniStatement()
        {
            Console.WriteLine("AXIX Bank Mini Statement");
        }

        public override void ValidateCard()
        {
            Console.WriteLine("AXIX Bank Validate Card");
        }

        public override void WithdrawMoney()
        {
            Console.WriteLine("AXIX Bank Withdraw Money");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transaction doing SBI Bank");
            //            SBI sBI = new SBI();
            IBank sBI = BankFactory.GetBankObject("SBI");
            sBI.ValidateCard();
            sBI.WithdrawMoney();
            sBI.CheckBalance();
            sBI.BankTransfer();
            sBI.MiniStatement();

            Console.WriteLine("");

            Console.WriteLine("Transaction doing AXIX Bank");
            //            AXIX aXIX = new AXIX();
            IBank aXIX = BankFactory.GetBankObject("AXIX");
            aXIX.ValidateCard();
            aXIX.WithdrawMoney();
            aXIX.CheckBalance();
            aXIX.BankTransfer();
            aXIX.MiniStatement();

            Console.Read();
        }
    }
}