using ClassLibrary1;
using System;

namespace ConsoleApp.net_framework_demo_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class AnotherClassLibrary1Class1 : ClassLibrary1Class1
    {
        public void Display4()
        {
            Console.WriteLine(Id);
        }
    }
    public class AnotherClassLibrary1Class2
    {
        public void Display3()
        {
            ClassLibrary1Class1 classLibrary1Class1 = new ClassLibrary1Class1();
            Console.WriteLine(classLibrary1Class1.Id);
        }
    }
    //public class MyClass2 : IDisposable
    //{
    //    #region IDisposable Support for class2
    //    private bool disposedValue = false;

    //    protected virtual void Dispose(bool disposing)
    //    {
    //        if (!disposedValue)
    //        {
    //            if (disposing)
    //            {
    //                // TODO: dispose managed state (managed objects)
    //            }

    //            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
    //            // TODO: set large fields to null
    //            disposedValue = true;
    //        }
    //    }

    //    // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    //    ~MyClass2()
    //    {
    //        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //        Dispose(disposing: false);
    //    }

    //    public void Dispose()
    //    {
    //        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //        Dispose(disposing: true);
    //        GC.SuppressFinalize(this);
    //    }
    //    #endregion
    //    //~MyClass2()
    //    //{
    //    //    Console.WriteLine("class2");
    //    //}

    //}

}