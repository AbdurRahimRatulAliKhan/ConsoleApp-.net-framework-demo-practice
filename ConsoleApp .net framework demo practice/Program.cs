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
    class Employee
    {
        public int Id, Age;
        public string Address, Name;
        public bool IsPermanent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="age"></param>
        /// <param name="address"></param>
        /// <param name="name"></param>
        /// <param name="isPermanent"></param>
        public Employee(int id, int age, string address, string name, 
            bool isPermanent)
        {
            Id = id;
            Age = age;
            Address = address;
            Name = name;
            IsPermanent = isPermanent;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"IsPermanent: {IsPermanent}");
        }
    }

    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Employee GYM = new Employee(110111, 30, 
                "CL(USA)", "Amir", true);
            GYM.Display();
            Console.WriteLine();

            Employee ranch = new Employee(110222, 40,
                "Canada", "John", false);
            ranch.Display();
            Console.ReadKey();
        }
    }
}
