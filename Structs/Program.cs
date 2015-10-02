using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Point() {X =3};
            Offset(ref p);
            Console.WriteLine(p.X);
            Console.Read();
            return;
           

        }

        static void Offset(ref Point p)
        {
            p.X += 1;
        }
    }
}
