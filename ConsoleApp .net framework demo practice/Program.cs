using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.net_framework_demo_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CopyConstructor copyConstructor1 = new CopyConstructor(10);
            copyConstructor1.Display();
            CopyConstructor copyConstructor2 = new CopyConstructor(copyConstructor1);
            copyConstructor2.Display();
            Console.ReadKey();
        }

        class CopyConstructor
        {
            int x;
            public CopyConstructor(int i)
            {
                x = i;
            }
            public CopyConstructor(CopyConstructor obj)
            {
                x = obj.x;
            }
            public void Display()
            {
                Console.WriteLine($"x: {x}");
            }
        }
    }
}
