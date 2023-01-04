using ClassLibrary1;
using System;

namespace ConsoleApp.net_framework_demo_practice
{
    public class Bank
    {
        private int Amount;
        public int GetAmount()
        {
            return Amount;
        }
        public void SetAmount(int Amount)
        {
            if (Amount > 0)
            {
                this.Amount = Amount;
            }
            else
            {
                throw new Exception("Please pass a positive value");
                //Console.WriteLine("Please pass a positive value");
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Bank bank = new Bank();
                bank.SetAmount(10);
                Console.WriteLine(bank.GetAmount());

                bank.SetAmount(-150);
                Console.WriteLine(bank.GetAmount());
            }
            catch (Exception ex)
            {

//                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}