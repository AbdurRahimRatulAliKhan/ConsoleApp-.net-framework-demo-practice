﻿using System;
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
            Parent parent = new Parent();
            Console.ReadKey();
        }
    }

    public static class Parent
    {
        public static double PI = 3.14;
        public static int GetSquare(int x)
        {
            return (x * x);
        }
    }
    public class Child : Parent
    {

    }
    
}
