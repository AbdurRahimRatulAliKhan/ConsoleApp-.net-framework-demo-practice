using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.net_framework_demo_practice
{
    class Program
    {
        static Program()
        {
            Console.WriteLine("static constructor");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main method");
            Console.ReadKey();
        }
    }
}
