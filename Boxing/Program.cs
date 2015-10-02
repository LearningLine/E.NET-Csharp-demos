using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            var j = Increment(i);
            Console.WriteLine(i);

            Console.WriteLine(CompareObject(i, i));
            Console.WriteLine(CompareObject("a", "a"));
            Console.WriteLine(CompareObject('a', 'a'));
            i = 1;
            j = 2;
            Swap(ref i, ref j);
            Console.WriteLine("i = " + i);
            Console.Read();
        }

        
        static void Swap(ref int i, ref int j)
        {
            var temp = i;
            i = j;
            j = temp;
        }

        static int Increment(int k)
        {
            k += 1;
            return k;
        }

public static bool CompareObject(object o1, object o2)
        {
            return o1 == o2;
        }
    }
}
