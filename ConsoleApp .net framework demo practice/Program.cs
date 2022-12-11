using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.net_framework_demo_practice
{
    /// <summary>
    /// 
    /// </summary>
    class First
    {
        public int x = 100;
    }
    /// <summary>
    /// 
    /// </summary>
    class Second
    {
        public int x;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        public Second(int x)
        {
            this.x = x;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            First first1 = new First();
            First first2 = new First();
            First first3 = new First();
            Console.WriteLine($"{first1.x} {first2.x} {first3.x}");
            Second second1 = new Second(10);
            Second second2 = new Second(20);
            Second second3 = new Second(30);
            Console.WriteLine($"{second1.x} {second2.x} {second3.x}");
            Console.ReadKey();
        }
    }
}
