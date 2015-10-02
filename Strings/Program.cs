using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "Hello";
            s = s.Replace("l", "x");
            Console.WriteLine(s);
            var s2 = "Hexxo";
            //Console.WriteLine(s == s2);
            Console.WriteLine(s.Equals(s2));
            Console.WriteLine(s == s2);
            object o = s;
            object o2 = s2;
            Console.WriteLine(o == o2);
            var s3 = "Hexxo";
            object o3 = s3;
            Console.WriteLine(o3 == o2);
            Console.Read();

        }
    }
}
