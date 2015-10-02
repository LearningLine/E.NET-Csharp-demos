using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer {Interval = 1000};
            timer.Elapsed += (sender, e) => {
                Console.WriteLine("timer 1");
            };
            ElapsedEventHandler h = null;
            h = (sender, e) => {
                Console.WriteLine("timer 2");
                timer.Elapsed -= h;
            };
            timer.Elapsed += h;


      timer.Start();
            
            Console.Read();

        }
    }
}
