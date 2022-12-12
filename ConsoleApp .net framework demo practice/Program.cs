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
            Test test = new Test(10);
            test.Method1();
            Console.ReadKey();
        }
    }

    public class Test
    {
        /// <summary>
        /// private constructor
        /// </summary>
        private Test()
        {
            Console.WriteLine("Private constructor");
        }
        /// <summary>
        /// public constructor
        /// </summary>
        /// <param name="x"></param>
        public Test(int x)
        {
            Console.WriteLine("Public constructor");
        }
        public void Method1() 
        {
            Console.WriteLine("Method1");
        }
    }
}
