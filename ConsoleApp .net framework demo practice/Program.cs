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
            byte b1 = 66;
            Console.WriteLine($"Decimal: {b1}");
            Console.WriteLine("ASCII value: " + (char)b1);
            Console.WriteLine($"Byte min value: {sbyte.MinValue} Byte Max value {sbyte.MaxValue}");
            Console.WriteLine(sizeof(sbyte));

            sbyte sb1 = 66;
            sbyte sb2 = -100;
            Console.WriteLine($"Decimal: {sb1}");
            Console.WriteLine("ASCII value: " + (char)sb1);
            Console.WriteLine("ASCII value: " + (char)sb2);
            Console.WriteLine($"Byte min value: {sbyte.MinValue} Byte Max value {sbyte.MaxValue}"); 
            Console.WriteLine(sizeof(sbyte));
            Console.ReadKey();
        }
    }
}
