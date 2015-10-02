using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l;
            var d = new Dictionary<Point, string>();
            d.Add(new Point {X = 10000, Y = 123123}, "Los Angeles" );
            Console.WriteLine(d [ new Point { X = 10000, Y = 123123 }]);
            Console.Read();
        }
    }
}
