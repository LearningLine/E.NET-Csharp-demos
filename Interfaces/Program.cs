using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            INraMember p = new NraPainter();
            p.Draw();
            new NraPainter().Draw();
            Console.Read();
        }
    }

    interface INraMember
    {
        void Draw();
    }

    interface IPainter
    {
        void Draw();
    }

    class NraPainter: INraMember, IPainter
    {
        void INraMember.Draw()
        {
            Console.WriteLine("BANG");
        }
        void IPainter.Draw()
        {
            Console.WriteLine("brush brush");
        }

        public void Draw()
        {
            Console.WriteLine("something else");
        }
    }
}
