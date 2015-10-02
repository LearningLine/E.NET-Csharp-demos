using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Customer("John", "Ford");
            c.FirstName = "Johnny";
            Console.WriteLine(c.FullName);
            c.Age = -999;

        }
    }
}
