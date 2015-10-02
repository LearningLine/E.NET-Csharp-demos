using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Strings2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStrings = new List<string>() {"a", "b", "c"};
            var s = "";
            foreach (var item in myStrings)
            {
                s += item;
            } // BAD
            StringBuilder sb = new StringBuilder();
            foreach (var item in myStrings)
            {
                sb.Append(item);
            }//GOOD
            sb.ToString();
            string.Join("", myStrings); //GOOD

        }
    }
}
