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
            Int16 num1 = 123;
            Int32 num2 = 456;
            Int64 num3 = 789;

            Console.WriteLine($"Min: {Int16.MinValue} " +
                $"Max: {Int16.MaxValue} " +
                $"Size: {sizeof(Int16)}");

            Console.WriteLine($"Min: {Int32.MinValue} " +
                $"Max: {Int32.MaxValue} " +
                $"Size: {sizeof(Int32)}");

            Console.WriteLine($"Min: {Int64.MinValue} " +
                $"Max: {Int64.MaxValue} " +
                $"Size: {sizeof(Int64)}");

            Console.ReadKey(true);
        }
    }
}
