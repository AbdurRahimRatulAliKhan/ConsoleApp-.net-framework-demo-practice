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
            Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi{name}");
            Console.ReadKey();
        }
    }
}
