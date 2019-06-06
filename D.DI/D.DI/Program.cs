using System;
using System.IO;


namespace D.DI
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\temp|folder1");

            // var files = Directory.GetFiles("...");
            //foreach(var file in files)
            //Console.WriteLine(files);

            var directories = Directory.GetDirectories("...", "*.*", SearchOption.AllDirectories);
            foreach(var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");
            var directoryinfo = new DirectoryInfo("...");
            directoryinfo.GetFiles();
            directoryinfo.GetDirectories();
        }
    }
}
