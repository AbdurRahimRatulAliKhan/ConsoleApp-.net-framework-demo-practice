using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.net_framework_demo_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Title = "Understanding Console Class";
            Console.WriteLine("BackgroundColor: Green");
            Console.WriteLine("ForegroundColor: Blue");
            Console.WriteLine("Title: Understanding Console Class");

            Console.Beep();
            Console.ReadKey();
        }
    }
}
