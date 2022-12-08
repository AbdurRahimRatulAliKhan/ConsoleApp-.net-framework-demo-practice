﻿using System;
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
            Single a = 1.123F;
            Double b = 1.456;
            Decimal c = 1.789M;

            Console.WriteLine($"Size: {sizeof(Single)} " +
                $"Max: {Single.MaxValue} " +
                $"Min: {Single.MinValue}");
            Console.WriteLine($"Size: {sizeof(Double)} " +
                $"Max: {Double.MaxValue} " +
                $"Min: {Double.MinValue}");
            Console.WriteLine($"Size: {sizeof(Decimal)} " +
                $"Max: {Decimal.MaxValue} " +
                $"Min: {Decimal.MinValue}");
            Console.ReadKey();
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
