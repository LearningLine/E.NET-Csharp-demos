using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter method name");
            var s = Console.ReadLine();
            typeof (Program).GetMethod(s).Invoke(null, new object[0]);
            Console.Read();
        }

        public static void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public static void Method2()
        {
            Console.WriteLine("Method 2");

        }
    }
}
