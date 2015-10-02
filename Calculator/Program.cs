using System;
using System.Net.WebSockets;
using Math;
using MSMath = System.Math;
namespace Calculator
{
    class Program
    {
        static void Main()
        {
            var i = ReadValue("enter number 1");
            Int32 j = ReadValue();
            var dummy = MSMath.Asin(0.5);
            var a = new Arithmetic();
            var result = a.Add("1", j);
            Console.WriteLine("result = " + result);
            Console.Read();
        }

        private static int ReadValue(string message = "Enter a value")
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
    }
}
