using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Model1())
            {
                foreach (var movie in context.Movies)
                {
                    Console.WriteLine(movie.Name);
                }
            }Console.Read();
        }
        
    }
}
