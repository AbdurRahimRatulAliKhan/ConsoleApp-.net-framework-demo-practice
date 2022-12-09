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
            unsafe
            {
                int number = 10;
                int* ptr = &number;
                Console.WriteLine(number);
                Console.WriteLine((int)ptr);
                Console.ReadKey();
            }
            //Console.WriteLine($"default byte: {default(byte)}");
            //Console.WriteLine($"default int: {default(int)}");
            //Console.WriteLine($"default float: {default(float)}");
            //Console.WriteLine($"default long: {default(long)}");
            //Console.WriteLine($"default double: {default(double)}");
            //Console.WriteLine($"default char: {default(char)}");
            //Console.WriteLine($"default bool: {default(bool)}");
            //Console.ReadKey();
            //Console.WriteLine($"byte: {sizeof(byte)}");
            //Console.WriteLine($"int: {sizeof(int)}");
            //Console.WriteLine($"char: {sizeof(char)}");
            //Console.WriteLine($"float: {sizeof(float)}");
            //Console.WriteLine($"long: {sizeof(long)}");
            //Console.WriteLine($"double: {sizeof(double)}");
            //Console.WriteLine($"bool: {sizeof(bool)}");
            //Console.ReadKey();
            //Stopwatch stopwatch1 = new Stopwatch();
            //stopwatch1.Start();
            //for (int i = 0; i <= 10000000; i++)
            //{
            //    short s1 = 100;
            //    short s2 = 100;
            //    short s3 = 100;
            //}
            //stopwatch1.Stop();
            //Console.WriteLine(stopwatch1.ElapsedMilliseconds);

            //Stopwatch stopwatch2 = new Stopwatch();
            //stopwatch2.Start();
            //for (int i = 0; i <= 10000000; i++)
            //{
            //    decimal s1 = 100;
            //    decimal s2 = 100;
            //    decimal s3 = 100;
            //}
            //stopwatch2.Stop();
            //Console.WriteLine(stopwatch2.ElapsedMilliseconds);
            //Console.ReadKey();
            //float a = 1.78986380830029492956829698978655434342477F;
            //double b = 1.78986380830029492956829698978655434342477;
            //decimal c = 1.78986380830029492956829698978655434342477M;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.ReadKey();
            //float a = 1.123F;
            //double b = 1.456;
            //decimal c = 1.789M;

            //Console.WriteLine($"Size: {sizeof(float)} " +
            //    $"Max: {float.MaxValue} " +
            //    $"Min: {float.MinValue}");
            //Console.WriteLine($"Size: {sizeof(double)} " +
            //    $"Max: {double.MaxValue} " +
            //    $"Min: {double.MinValue}");
            //Console.WriteLine($"Size: {sizeof(decimal)} " +
            //    $"Max: {decimal.MaxValue} " +
            //    $"Min: {decimal.MinValue}");
            //Console.ReadKey();

            //Single a = 1.123F;
            //Double b = 1.456;
            //Decimal c = 1.789M;

            //Console.WriteLine($"Size: {sizeof(Single)} " +
            //    $"Max: {Single.MaxValue} " +
            //    $"Min: {Single.MinValue}");
            //Console.WriteLine($"Size: {sizeof(Double)} " +
            //    $"Max: {Double.MaxValue} " +
            //    $"Min: {Double.MinValue}");
            //Console.WriteLine($"Size: {sizeof(Decimal)} " +
            //    $"Max: {Decimal.MaxValue} " +
            //    $"Min: {Decimal.MinValue}");
            //Console.ReadKey();
            //            Int16 num1 = 123;
            //ushort num1 = 123;    // 2 bytes
            //                     //            Int32 num2 = 456;
            //uint num2 = 456;    // 4 bytes
            //                   //            Int64 num3 = 789;
            //ulong num3 = 789; // 8 bytes

            //Console.WriteLine($"Min: {ushort.MinValue} " +
            //    $"Max: {ushort.MaxValue} " +
            //    $"Size: {sizeof(ushort)}");

            //Console.WriteLine($"Min: {uint.MinValue} " +
            //    $"Max: {uint.MaxValue} " +
            //    $"Size: {sizeof(uint)}");

            //Console.WriteLine($"Min: {ulong.MinValue} " +
            //    $"Max: {ulong.MaxValue} " +
            //    $"Size: {sizeof(ulong)}");

            //Console.ReadKey(true);


            ////            Int16 num1 = 123;
            //             short num1 = 123; // 2 bytes
            ////            Int32 num2 = 456;
            //             int num2 = 456; // 4 bytes
            ////            Int64 num3 = 789;
            //             long num3 = 789; // 8 bytes

            //            Console.WriteLine($"Min: {short.MinValue} " +
            //                $"Max: {short.MaxValue} " +
            //                $"Size: {sizeof(short)}");

            //            Console.WriteLine($"Min: {int.MinValue} " +
            //                $"Max: {int.MaxValue} " +
            //                $"Size: {sizeof(int)}");

            //            Console.WriteLine($"Min: {long.MinValue} " +
            //                $"Max: {long.MaxValue} " +
            //                $"Size: {sizeof(long)}");

            //            Console.ReadKey(true);
        }
    }
}
