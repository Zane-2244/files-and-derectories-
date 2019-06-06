using System;
using System.IO;

namespace PH
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "...";
            var dotindex = path.IndexOf('.');
            var extension = path.Substring(dotindex);
            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("file name: "+ Path.GetFileName(path));
            Console.WriteLine("file name without Extension: "+Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("DIrectory name:"+Path.GetDirectoryName(path));
        }
    }
}
