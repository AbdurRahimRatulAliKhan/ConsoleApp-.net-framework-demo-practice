using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp.net_framework_demo_practice
{
    class Program
    {
        private Program()
        {
            Console.WriteLine("Private parameterless constructor");
        }
        private Program(string message)
        {
            Console.WriteLine("Private parameterized constructor");
        }
        static void Main(string[] args)
        {
            Program program1 = new Program();
            Program program2 = new Program("Hi");
            Console.ReadKey(true);
        }
    }
    
}
