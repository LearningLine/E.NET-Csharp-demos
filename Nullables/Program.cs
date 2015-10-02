using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Age = null;
            Console.WriteLine(p.Age.HasValue);
            Console.WriteLine(p.Age);
            p.Age = 12;
            Console.WriteLine(p.Age);
            int age = (int)p.Age;
            Console.Read();
        }
    }

    class Person
    {
        public int? Age { get; set; }
    }
}
