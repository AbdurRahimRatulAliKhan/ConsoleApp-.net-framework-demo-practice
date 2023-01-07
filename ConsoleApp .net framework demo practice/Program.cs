using ClassLibrary1;
using System;

namespace ConsoleApp.net_framework_demo_practice
{
    public class Bank
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
                        throw new Exception("Please pass a positive value");
                    }
                    else
                    {
                        _Amount = value;
                    }
            }
        }
        
    }
    class Program
    {
        public static void Main()
        {
            try
            {
                Bank bank = new Bank();
                bank.Amount = 10;
                Console.WriteLine(bank.Amount);
                bank.Amount = -150;
                Console.WriteLine(bank.Amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.ReadKey();
        }
    }
}