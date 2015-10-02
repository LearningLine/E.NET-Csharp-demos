using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unpacking
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] {1, 2, 3};
            Test(1,2,3);
            Test2(a:3, b:2);
        }

        private static void TestMethod()
        {
            
        }
        private static void Test(params int [] arguments)
        {
         
        }
        private static void Test2(int a , int b)
        {

        }

    }
}
