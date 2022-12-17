using System;

namespace ConsoleApp.net_framework_demo_practice
{
    public class DestructorDemo
    {
        public DestructorDemo()
        {
            Console.WriteLine("Unmanaged Resource Created");
        }
        ~DestructorDemo()
        {
            Console.WriteLine("Unmanaged Resource Distroyed");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            DestructorDemo destructorDemo = new DestructorDemo();
            Console.WriteLine("Using Unmanaged Resource");
            destructorDemo = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}