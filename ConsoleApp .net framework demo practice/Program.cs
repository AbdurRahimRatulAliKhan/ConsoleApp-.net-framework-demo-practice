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
            ParameterizedConstructor parameterizedConstructor1 = 
                new ParameterizedConstructor(10);
            ParameterizedConstructor parameterizedConstructor2 =
                new ParameterizedConstructor(20);
            Console.ReadKey();
        }

        class ParameterizedConstructor
        {
            public ParameterizedConstructor(int i)
            {
                Console.WriteLine($"Parameterized Constructor  " +
                    $"is called: {i}");
            }
        }
        
        ///// <summary>
        ///// 
        ///// </summary>
        //public int Id, Age;
        //public string Address, Name;
        //public bool IsPermanent;
        ///// <summary>
        ///// 
        ///// </summary>
        //public Program()
        //{
        //    Id = 100;
        //    Age = 30;
        //    Address = "Dhaka";
        //    Name = "John";
        //    IsPermanent = true;
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        //public void Display()
        //{
        //    Console.WriteLine($"Id: {Id}");
        //    Console.WriteLine($"Age: {Age}");
        //    Console.WriteLine($"Address: {Address}");
        //    Console.WriteLine($"Name: {Name}");
        //    Console.WriteLine($"Is Employee Permanent: {IsPermanent}");
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    Program employee = new Program();
        //    employee.Display();

        //    Console.ReadKey();
        //}

    }
}
