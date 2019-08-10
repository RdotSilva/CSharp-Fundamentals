using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";

            // Static methods
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);

            // Instance methods
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");

            if (fileInfo.Exists)
            {
                //
            }
            fileInfo.Read
        }
    }
}
