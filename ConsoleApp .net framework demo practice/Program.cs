using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.net_framework_demo_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integer: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 + number2;
            Console.WriteLine("sum: " + result);
            Console.WriteLine($"Sum = {number1 + number2}");
            Console.ReadKey();
        }
    }
}
