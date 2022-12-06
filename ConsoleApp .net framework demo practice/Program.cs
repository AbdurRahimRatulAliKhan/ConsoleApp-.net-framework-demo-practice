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
            Console.WriteLine("Enter a key: ");
            int var1 = Console.Read();
            Console.WriteLine("ASCII value of the entered key is: " + var1);
            
            Console.WriteLine("Enter another key: ");
            ConsoleKeyInfo var2 = Console.ReadKey();
            Console.WriteLine($"\nEntered key: {var2.Key} " +
                $"KeyChar: {var2.KeyChar} " +
                $"ASCII: {(int)var2.KeyChar}");
            Console.ReadKey();
        }
    }
}
