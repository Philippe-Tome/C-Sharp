using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Part9_code_along
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 3. Demo File and FileInfo:
            //    // File: (to run small operations it is more convenient to use static method, it can be slow for large applications)
            //    var path = @"c:\somefile.jpg";
            //    File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            //    File.Delete(path);
            //    if (File.Exists(path))
            //    {
            //        //
            //    }
            //    var content = File.ReadAllText(path);

            //    // FileInfo class: (if large application it is more efficient to create a FileInfo object and call the instance of that object)
            //    var fileInfo = new FileInfo(path);
            //    fileInfo.CopyTo("...");
            //    fileInfo.Delete();
            //    if (fileInfo.Exists);
            //    {
            //        //
            //    }

            // 4. Demo Directory and DirectoryInfo:
                // Directory:
                //Directory.CreateDirectory(@"c:\temp\folder1");

                //var files = Directory.GetFiles(@"c:\BASE8", "*.txt", SearchOption.AllDirectories);
                //foreach (var file in files)
                //    Console.WriteLine(file);

                //var directories = Directory.GetDirectories(@"c:\BASE8", "*.*", SearchOption.AllDirectories);
                //foreach(var directory in directories)
                //    Console.WriteLine(directory );

                //Directory.Exists("...");

                //// DirectoryInfo:
                //var directoryInfo = new DirectoryInfo("...");
                //directoryInfo.GetDirectories();

                // Google: file info class c#. MSDN

            // 5. Demo Path:
                var path = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

                // Poor way of doing it:
                var dotIndex = path.IndexOf('.');
                var extension = path.Substring(dotIndex);

                Console.WriteLine("Extension: " + Path.GetExtension(path));
                Console.WriteLine("File Name: " + Path.GetFileName(path));
                Console.WriteLine("File Name without extension: " + Path.GetFileNameWithoutExtension(path));
                Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

        }
    }
}
