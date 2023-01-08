using ClassLibrary1;
using System;

namespace ConsoleApp.net_framework_demo_practice
{
    public class SBI
    {
        public void BankTransfer()
        {
            Console.WriteLine("SBI Bank Bank Transfer");
        }

        public void CheckBalance()
        {
            Console.WriteLine("SBI Bank Check Balance");
        }

        public void MiniStatement()
        {
            Console.WriteLine("SBI Bank Mini Statement");
        }

        public void ValidateCard()
        {
            Console.WriteLine("SBI Bank Validate Card");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank Withdraw Money");
        }
    }

    public class AXIX
    {
        public void BankTransfer()
        {
            Console.WriteLine("AXIX Bank Bank Transfer");
        }

        public void CheckBalance()
        {
            Console.WriteLine("AXIX Bank Check Balance");
        }

        public void MiniStatement()
        {
            Console.WriteLine("AXIX Bank Mini Statement");
        }

        public void ValidateCard()
        {
            Console.WriteLine("AXIX Bank Validate Card");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("AXIX Bank Withdraw Money");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transaction doing SBI Bank");
            SBI sBI = new SBI();
            sBI.ValidateCard();
            sBI.WithdrawMoney();
            sBI.CheckBalance();
            sBI.BankTransfer();
            sBI.MiniStatement();

            Console.WriteLine("");

            Console.WriteLine("Transaction doing SBI Bank");
            AXIX aXIX = new AXIX();
            aXIX.ValidateCard();
            aXIX.WithdrawMoney();
            aXIX.CheckBalance();
            aXIX.BankTransfer();
            aXIX.MiniStatement();

            Console.Read();
        }
    }
}