using System;

namespace ConsoleApp.net_framework_demo_practice
{
    public class UnmanagedResource : IDisposable
    {
        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    Console.WriteLine("Managed resoucrces destroyed by disposed method");
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                Console.WriteLine("unmanaged resources destroyed by dispose method");
                disposedValue = true;
            }
            else
            {
                Console.WriteLine("resources are already destroyed by dispose method");
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
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }

    class Program
    {
//        static void Main(string[] args)
        static void Main()
        {
            UnmanagedResource unmanagedResource = null;
            try
            {
                unmanagedResource= new UnmanagedResource();
                Console.WriteLine("using resources");
            }
            finally
            {
                if (unmanagedResource != null)
                {
                    Console.WriteLine("calling dispose method to destroy resources");
                    unmanagedResource.Dispose();
                }
            }

            Console.WriteLine();
            Console.WriteLine("trying to call the dispose method again to destroy resources");
            unmanagedResource.Dispose();
            Console.ReadKey();
        }
    }
}