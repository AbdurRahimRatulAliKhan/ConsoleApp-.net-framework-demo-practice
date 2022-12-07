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
            char ch = 'B';
            Console.WriteLine($"Char value: {ch} " +
                $"Equivalent number: {(byte)ch} " +
                $"char min value {(int)char.MinValue} " +
                $"and char max value {(int)char.MaxValue} " +
                $"char size {sizeof(char)}");
            Console.ReadKey();
        }
    }
}
