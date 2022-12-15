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
    class DestructorDemo
    {
        public DestructorDemo()
        {
            Console.WriteLine("Constructor Object Created");
        }
        ~DestructorDemo()
        {
            //            string type = GetType().Name;
            string type = GetType().Name;
            Console.WriteLine($"Object {type} type is Destroyed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DestructorDemo destructorDemo1 = new DestructorDemo();
            DestructorDemo destructorDemo2 = new DestructorDemo();

            destructorDemo1 = null;
//            destructorDemo2 = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}
