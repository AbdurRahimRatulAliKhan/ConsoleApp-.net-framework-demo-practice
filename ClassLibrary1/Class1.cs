using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClassLibrary1Class1
    {
//        private int Id;
//        public int Id;
//        protected int Id;
//        internal int Id;
//        protected internal int Id;
        private protected int Id;
        public void Display1()
        {
            Console.WriteLine(Id);
        }
    }
    public class ClassLibrary1Class2 : ClassLibrary1Class1
    {
        public void Display2()
        {
            Console.WriteLine(Id);
        }
    }
    public class ClassLibrary1Class3
    {
        public void Display3()
        {
            ClassLibrary1Class1 classLibrary1Class1 = new ClassLibrary1Class1();
            Console.WriteLine(classLibrary1Class1.Id);
        }
    }
}
