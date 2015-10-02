using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArray =  new[]{1, 2, 3, 4, 5};
            myArray[3] = 2;
            var myArray2 = new object[] {1, "hello"};
            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.WriteLine(myArray2[i]);
            }
            foreach(object item in myArray2)
                Console.WriteLine(item);
            int [] arrayOfZeros = new int[1000];
        }
    }
}
