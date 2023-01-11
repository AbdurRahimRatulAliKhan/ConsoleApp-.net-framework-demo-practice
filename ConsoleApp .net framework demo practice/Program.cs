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
            A reference; //instanceA is a variable of class A
            B instance = new B(); // instanceB is an instance of class B
            reference = instance; // now variableA is a reference of parent calss created by using child class instance 
            //now we can call members of class A as follows
            reference.Method1();
            reference.Method2();

            Console.WriteLine("");
            //calling by the instance
            instance.Method1();
            instance.Method2();
            instance.Method3();
            Console.Read();
        }
    }
}