using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\Dev\TestFolder\Example.txt";


            /*
            // Old way of using resources:
            //
            // This locks the file when you open it for writing
            // You have to specifically close it to release for other uses.
            var file = File.Open(path, FileMode.Open);
            // TODO read/write
            file.Close();
            */



            // You can define the use of a RESOURCE in a code block with 'using' codeword:
            // Will automatically release resource (by calling Dispose) when you leave code block.
            // VERY common to use when accessing streams
            using (var file = File.Open(path, FileMode.Open))
            {
                // TODO read/write

            }




        }
    }
}
