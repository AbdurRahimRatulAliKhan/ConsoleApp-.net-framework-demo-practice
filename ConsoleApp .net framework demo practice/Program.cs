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
            Console.WriteLine("Private Constructor");
        }
        public void Method1()
        {
            Console.WriteLine("Method1 is called!");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Method1();
            Console.ReadKey();
        }
    }
}
