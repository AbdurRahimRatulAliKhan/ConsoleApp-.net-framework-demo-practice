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
            Parent.Child child = new Parent.Child();  
            Console.ReadKey(true);
        }
    }

    public class Parent
    {
        private Parent()
        {
            Console.WriteLine("parent calss private constructor");
        }
        

        public class Child : Parent
        {
            public Child()
            {
                Console.WriteLine("child class public constructor");
            }
        }
    }
    
}
