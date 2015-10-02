using System;
using MyExtensions;
namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 3;
            Console.WriteLine(n.Squared()); // MyMath.Squared(n)
            Console.WriteLine("hello_world".PascalCased());
            Console.Read();
        }
    }

   
}
