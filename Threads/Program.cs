using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(Test);
            thread.Start();
            Thread thread2 = new Thread(Test);
            thread2.Start();
            Test();
        }

        private static void Test()
        {
            for (int i = 0; i < 10000000; i++)
            {
                Console.WriteLine("{0} - {1}", i, Thread.CurrentThread.ManagedThreadId);

            }
        }
    }
}
