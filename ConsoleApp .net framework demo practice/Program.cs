using ClassLibrary1;
using System;

namespace ConsoleApp.net_framework_demo_practice
{
    class A
    {
        public A()
        {
            Console.WriteLine("Class A constructor is called!");
        }
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
        public Program()
        {
            Console.WriteLine("class program constructor is called!");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Method1();
            program.Method2();
            program.Method3();
            Console.Read();
        }
    }
}