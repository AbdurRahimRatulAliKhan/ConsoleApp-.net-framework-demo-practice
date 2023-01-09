using ClassLibrary1;
using System;

namespace ConsoleApp.net_framework_demo_practice
{
    class A
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
    class Program : A
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Method1();
            program.Method2();
            Console.Read();
        }
    }
}