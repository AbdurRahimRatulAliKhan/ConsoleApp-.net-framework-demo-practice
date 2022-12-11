using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.net_framework_demo_practice
{
    class First
    {
        public int x = 100;
    }
    class Second
    {
        public int x;
    }
    class Program
    {
        static void Main(string[] args)
        {
            First first1 = new First();
            First first2 = new First();
            First first3 = new First();
            Console.WriteLine($"{first1.x} {first2.x} {first3.x}");
            Second second1 = new Second();
            Second second2 = new Second();
            Second second3 = new Second();
            Console.WriteLine($"{second1.x} {second2.x} {second3.x}");
            Console.ReadKey();
        }
    }
}
