using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeStats
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>() {1,2,3};
            foreach (var item in l.Where(item => item > 3))
            {
                Console.WriteLine(item);
            }
            const string folderName = @"C:\Users\Pierre\Documents\Visual Studio 2015\Projects\ClassCode";
            var files = Directory.GetFiles(folderName, "*.cs", SearchOption.AllDirectories);
            Console.WriteLine("file count = " + files.Length);
            Console.WriteLine("line count = " + files.SelectMany(File.ReadAllLines).Count());
            Console.WriteLine("non empty line count = " + files.SelectMany(File.ReadAllLines).Count(line => line.Trim().Length > 0));
            Console.Read();
            string s = "abc";
            s.Count(c => c == 'b');
        }
    }
}
