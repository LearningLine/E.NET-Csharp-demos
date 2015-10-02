using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Staff();
            e.Promote();
            Console.Read();
            bool b = e is Staff; // OK for descendants
            bool b2 = e.GetType() == typeof (Staff); // Exact type
        }
    }
}
