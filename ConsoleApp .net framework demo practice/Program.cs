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
    class B : A
    {
        public B()
        {
            Console.WriteLine("class program constructor is called!");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main(string[] args)
        {
            Object obj1 = new Object();
            Console.WriteLine($"obj1 type: {obj1.GetType()}");
            
            Console.WriteLine("");
            A obj2 = new A();
            Console.WriteLine($"obj2 type: {obj2.GetType()}");

            Console.WriteLine("");
            B obj3 = new B();
            Console.WriteLine($"obj3 type: {obj3.GetType()}");

            Console.ReadKey();
        }
    }
}