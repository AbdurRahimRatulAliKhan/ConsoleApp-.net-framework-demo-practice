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
    /// <summary>
    /// initial class
    /// </summary>
    class Example
    {
        int i;
        static int j;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Example()
        {
            Console.WriteLine($"Default constructor executed!");
            i = 100;
        }

        /// <summary>
        /// static constructor
        /// </summary>
        static Example()
        {
            Console.WriteLine($"static constructor executed!");
            j = 200;
        }

        /// <summary>
        /// increment operations for i and static j
        /// </summary>
        public void Increment()
        {
            i++;
            j++;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"i: {i} j: {j}");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Example example = new Example();
            example.Increment();
            example.Display();
            example.Increment();
            example.Display();
            Console.WriteLine();

            Example example2 = new Example();
            example2.Increment();
            example2.Display();
            example2.Increment();
            example2.Display();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
