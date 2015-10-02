using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtensions
{
    public static class MyMath
    {
        public static int Squared(this int i)
        {
            return i * i;
        }

        public static string PascalCased(this string s)
        {
            var words = s.Split('_');
            var result = "";
            foreach (var word in words)
            {
                result += word[0].ToString().ToUpper() + word.Substring(1).ToLower();
            }
            return result;
        }
    }
}
