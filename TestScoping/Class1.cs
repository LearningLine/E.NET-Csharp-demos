using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.B
{
    class MyOtherClass { }
}
namespace A
{
    namespace B
    {
        class MyClass
        {
            void Test()
            {
                var c = new MyClass();
            }
        }
    }

    class MyClass
    {
        void Test()
        {
            new MyClass();
        }
    }
}

namespace C
{
    class MyClass
    {
    }
}