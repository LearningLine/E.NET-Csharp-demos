using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] array = new string[3];
            array[1] = "Hello";
            List<string> list = new List<string> {"Hello", "World"};
            list.Remove("Hello");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Dictionary<string, int> dictionary = new Dictionary<string, int>
            { {"alice", 120000}, {"bob", 10000}};
            foreach (var pair in dictionary)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
            var amountForAlice = dictionary["alice"];
            dictionary["alice"] += 1000;
            dictionary.Remove("bob");
        }
    }

   
}
