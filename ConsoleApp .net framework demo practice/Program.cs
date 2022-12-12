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
        static void Main(string[] args)
        {
            Console.WriteLine("Main method started!");
            ConstructorDemo constructorDemo = new ConstructorDemo();
            Console.WriteLine("Main method completed!");
            Console.ReadKey();
        }
    }

    public class ConstructorDemo
    {
        static int x;
        int y;

        static ConstructorDemo()
        {
            Console.WriteLine("Static Constructor is called!");
        }

        public ConstructorDemo()
        {
            Console.WriteLine("Non-Static Constructor is called!");
        }
    }
}
