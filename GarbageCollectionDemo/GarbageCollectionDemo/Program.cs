using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    

    // interface marks that these types implement the Dispose method
    // works well with simple scenarios and sealed types, but
    // use the advanced pattern in most cases

    interface IDisposable
    {
        void Dispose();
    }


    //
    // Simple Dispose pattern:
    //
    /*
    public class SimpleDemo : IDisposable
    {
        public void Dispose()
        {
            // release resources
            // Set array size to 0 (zero), null etc.
        }
    }
    */

    //
    // Advanced Dispose Pattern
    //
    // Use for non-trivial disposable object

    public class AdvancedDemo : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // release managed resources
                // Other managed types that implements the Dispose pattern.
            }
            // release unmanaged resources
            // Eg external comm objects
        }

        // '~' sign is called a Finalizer. Is the INVERSE of a constructor. 
        // Performs an operation at the end of the lifecycle of a managed type.
        // Is called by the Garbage collector sometime in the future before collection.
        // Usually not necessary to do manually
        ~AdvancedDemo()
        {
            // This says that we have already cleared up our garbage, and 
            // Garbage Collector doesn't need to do it on these objects
            Dispose(false);
        }
    }



}
