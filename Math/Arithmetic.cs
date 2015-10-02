using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public  class Arithmetic
    {
        public int Add(object i, int j)
        {
            return System.Convert.ToInt32(i) + j;
        }

        internal int Subtract(int i, int j)
        {
            return i - j;
        }
        private int Multiply(int i, int j)
        {
            return i * j;
        }
    }

    class Test
    {
        public Test()
        {
            var a = new Arithmetic();
           
        }
    }
}
