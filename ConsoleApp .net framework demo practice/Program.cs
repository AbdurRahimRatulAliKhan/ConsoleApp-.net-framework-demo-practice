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
            Parent.Child1 child1 = new Parent.Child1();
            Parent.Child2 child2 = new Parent.Child2();
            Console.ReadKey();
        }
    }

    public sealed class Parent
    {
        private Parent()
        {
            Console.WriteLine("parent class private constructor");
        }
        public class Child1 : Parent
        {
            public Child1()
            {
                Console.WriteLine("child1 class public constructor");
            }
        }
        public class Child2 : Parent
        {
            public Child2()
            {
                Console.WriteLine("child2 class public constructor");
            }
        }
    }
    
}
