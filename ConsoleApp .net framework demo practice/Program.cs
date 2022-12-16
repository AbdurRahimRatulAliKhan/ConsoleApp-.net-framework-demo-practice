using System;

namespace ConsoleApp.net_framework_demo_practice
{
    class DestructorDemo
    {
        public DestructorDemo()
        {
            Console.WriteLine("DestructorDemo Object Created");
        }
        ~DestructorDemo()
        {
            Console.WriteLine($"DestructorDemo Object Destroyed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Execution started");
            DestructorDemo destructorDemo1 = new DestructorDemo();
            destructorDemo1 = null;
            GC.Collect();
            Console.WriteLine("some statement executed inside main method");

            destructorDemo1 = null;
            GC.Collect();
            Console.WriteLine("some more statement executed inside main method");

            GC.Collect();
            Console.WriteLine("Main method execution end");
            Console.ReadKey();
        }
    }
}