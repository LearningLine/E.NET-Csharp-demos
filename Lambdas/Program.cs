using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    internal delegate int MyDelegate(int i);

    internal delegate TOutput MyFunc<TInput, TOutput>(TInput input);
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            MyDelegate d = AddOne;
            MyDelegate d2 = delegate(int x)
            {
                return x + 1;
            };
            MyDelegate d3 = (int x) => { return x + 1; };
            MyDelegate d4 = x => x + 1;
            MyFunc<int, int> d5 = x => x + 1;
            Func<int, int> d6 = x => x + 1;

            var j = d(i);
            Console.WriteLine(j);
        }

        static int AddOne(int i)
        {
            return i + 1;
        }
    }
}
