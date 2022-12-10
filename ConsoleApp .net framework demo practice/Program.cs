using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.net_framework_demo_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExplicitConstructor explicitConstructor1 = new ExplicitConstructor();
            ExplicitConstructor explicitConstructor2 = new ExplicitConstructor();
            ExplicitConstructor explicitConstructor3 = new ExplicitConstructor();
            ExplicitConstructor explicitConstructor4 = new ExplicitConstructor();
            Console.ReadKey();
//            Test test = new Test();
//            Console.WriteLine($"i: {test.i}");
//            Console.WriteLine($"b: {test.b}");
////            Console.WriteLine(test.s);
//            if(test.s == null)
//            {
//                Console.WriteLine($"s: Null");
//            }
//            Console.ReadKey();
//            //Calculator calculator = new Calculator();
//            //int result = calculator.CalculateSum(10, 20);
//            //Console.WriteLine(result);
//            //Console.ReadKey();
        }

        class ExplicitConstructor
        {
            public ExplicitConstructor()
            {
                Console.WriteLine("Explicit Constructor is called!");
            }
        }
        //class Test
        //{
        //    public int i;
        //    public bool b;
        //    public string s;
        //}
        ////public class Calculator
        ////{
        ////    public int CalculateSum(int no1, int no2)
        ////    {
        ////        return no1 + no2;
        ////    }
        ////}

    }
}
