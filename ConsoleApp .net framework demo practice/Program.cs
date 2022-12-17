using System;

namespace ConsoleApp.net_framework_demo_practice
{
    public class DestructorDemo
    {
        ~DestructorDemo()
        {
            Console.WriteLine("Destructor of 1st called");
        }
    }
    public class DestructorDemo2 : DestructorDemo
    {
        ~DestructorDemo2()
        {
            Console.WriteLine("Destructor of 2nd called");
        }
    }
    public class DestructorDemo3 : DestructorDemo2
    {
        ~DestructorDemo3()
        {
            Console.WriteLine("Destructor of 3rd called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DestructorDemo3 destructorDemo3 = new DestructorDemo3();
            destructorDemo3 = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}