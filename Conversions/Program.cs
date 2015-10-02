using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            B b = a;
            C c = (B) a;
        }
    }

    class A
    {
        public static implicit operator B(A a)
        {
            return new B();
        }
    }

    class B
    {
        public static implicit operator C(B b)
        {
            return new C();
        }
    }
    class C { }
}
