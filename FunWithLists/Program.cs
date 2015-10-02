using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FunWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 100);
            string digit = "9";
            Console.WriteLine(
                string.Join(",\n", GetConsecutivePairs2(Enumerable.Range(1, 10))));
            var numbersWith9 = numbers.Where(n => n.ToString().Contains(digit));
            Console.WriteLine(numbersWith9.Count());
            Console.WriteLine(numbersWith9.Sum());
            var primes = GetPrimes();
            Console.WriteLine(GetPrimes().Take(20).Last());
            Console.WriteLine(GetPrimes().TakeWhile(x => x < 100).Count());
            Console.WriteLine(GetConsecutivePairs(GetPrimes()).First(p => p.Second > p.First + 100).Second);
            Console.Read();
        }


        static IEnumerable<long> GetPrimes()
        {
            var alreadyReturned = new List<long>();
            for (var n = 2; n < long.MaxValue; n++)
            {
                if (alreadyReturned.All(x => n % x != 0))
                {
                    yield return n;
                    alreadyReturned.Add(n);
                }
            }
        }
        public static IEnumerable<Pair<T>> GetConsecutivePairs<T>(IEnumerable<T> source)
        {
            T previous = default(T);
            bool hasPrevious = false;
            foreach (var item in source)
            {
                if (hasPrevious)
                {
                    yield return new Pair<T>(previous, item);
                }
                previous = item;
                hasPrevious = true;
            }
        }
        public static IEnumerable<Pair<T>> GetConsecutivePairs2<T>(IEnumerable<T> source)
        {
            T previous = source.First();
            foreach (var item in source.Skip(1))
            {
                yield return new Pair<T>(previous, item);
                previous = item;
            }
        }

        static IEnumerable<int> GetNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                yield return i;
            }
        } 
    }
}
