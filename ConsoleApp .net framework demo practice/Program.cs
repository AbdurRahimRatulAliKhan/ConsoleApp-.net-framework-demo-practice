using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp.net_framework_demo_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetSingletonInstance();
            singleton1.SomeMethod("from singleton1");
            Singleton singleton2 = Singleton.GetSingletonInstance();
            singleton2.SomeMethod("from singleton2");
            Console.ReadKey();
        }
    }

    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        
        private static readonly object Instancelock = new object();
        
        public static Singleton GetSingletonInstance()
        {
            lock (Instancelock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine($"singleton constructor executed {counter} times");
        }
        public void SomeMethod(string Message)
        {
            Console.WriteLine($"somemethod called {Message}");
        }
    }
    
}
