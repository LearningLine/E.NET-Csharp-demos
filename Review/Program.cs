using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Test();
            var currentTime = DateTime.Now;
        }

        void Test()
        {
            
        }

    }

    class Tester
    {
        public void TestMe()
        {
            MyClass.Test();
            var m =  new MyClass();
          //  m.Test();
        }
    }
    class MyClass
    {
        public static int MyField;
        public static void Test() { }
    }
}
