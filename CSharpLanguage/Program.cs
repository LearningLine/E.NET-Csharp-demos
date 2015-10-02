using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguage
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string s = "Hello";
            string s2 = "Hello";
            var f = 2d;
            var i = 1L;
            f = 1.5;
            double d = i;
            Math.Exp(i);
            Console.WriteLine(new Customer {Name = "Nicole"});
            Console.Read();
            Customer c = new Customer();
            if (i == 1)
                c = null;
            Console.WriteLine(c?.Name);
            
        }

        
        /// <summary>
        /// Gets a customer info.
        /// </summary>
        /// <returns></returns>
        public static Customer GetCusmoterInfo()
        {
            return null;
        }
    }

    internal class Customer
    {
        public string Name;
        public override string ToString()
        {
            return IsImportant ? "*******" + Name : Name;
        }

        public bool IsImportant;


    }
}
