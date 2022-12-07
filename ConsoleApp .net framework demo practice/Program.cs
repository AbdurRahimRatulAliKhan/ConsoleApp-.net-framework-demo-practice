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
            string value = "ABC";
            var howmanybytes = value.Length * sizeof(char);
            Console.WriteLine($"{value} {howmanybytes}");
            Console.ReadKey();
        }
    }
}
