using System;
using System.Collections.Generic;

namespace FunWithLists
{
    public static class Utilities
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                    yield return item;
            }
        }

        public static int MySum(this IEnumerable<int> source)
        {
            var sum = 0;
            foreach (var number in source)
            {
                sum += number;
            }
            return sum;
        }
        public static int NumberOfItems<T>(this IEnumerable<T> source)
        {
            int result = 0;
            foreach (var item in source)
            {
                result++;
            }
            return result;
        }
    }
}