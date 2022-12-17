using System;

namespace ConsoleApp.net_framework_demo_practice
{
    public class UnmanagedResource : IDisposable
    {
        #region IDisposable Support
//        private bool disposedValue = false;
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    Console.WriteLine("4: Managed resoucrces destroyed by disposed method");
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                Console.WriteLine("5: unmanaged resources destroyed by dispose method");
                disposedValue = true;
            }
            else
            {
                Console.WriteLine("7: resources are already destroyed by dispose method");
            }
        }

        // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~UnmanagedResource()
        {
            Console.WriteLine("request comes to destructor to destroy the resources");
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Console.WriteLine("3: request comes to dispose method to destroy the resources");
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
//            GC.Collect();
            GC.SuppressFinalize(this);
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
//        static void Main()
        {
            UnmanagedResource unmanagedResource = null;
            try
            {
                unmanagedResource = new UnmanagedResource();
                Console.WriteLine("1: using resources");
            }
            finally
            {
                if (unmanagedResource != null)
                {
                    Console.WriteLine("2: calling dispose method to destroy resources");
                    unmanagedResource.Dispose();
                }
            }

            Console.WriteLine();
            Console.WriteLine("6: trying to call the dispose method again to destroy resources");
            unmanagedResource.Dispose();
            Console.ReadKey();
        }
    }
}