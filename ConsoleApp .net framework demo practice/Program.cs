using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.net_framework_demo_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int result = calculator.CalculateSum(10, 20);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public class Calculator
        {
            public int CalculateSum(int no1, int no2)
            {
                return no1 + no2;
            }
        }
    }
}
