using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.LINQ.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupResult1 = GetSequence()
                .Where(n => n % 2 == 0)
                .GroupBy(k => "Even");

            foreach (var item in groupResult1)
            {
                Console.WriteLine($"Key: {item.Key}");
                foreach (var e in item)
                {
                    Console.WriteLine($"Value: {e}");
                }
            }

            Console.WriteLine("--------------------------------------");

            var groupResult2 = GetSequence()
                .Where(n => n % 2 != 0)
                .GroupBy(k => "Squares of odd numbers", k => k * k);

            foreach (var item in groupResult2)
            {
                Console.WriteLine($"Key: {item.Key}");
                foreach (var e in item)
                {
                    Console.WriteLine($"Value: {e}");
                }
            }
        }

        static IEnumerable<int> GetSequence()
        {
            int i = 1;

            while (i <= 10)
            {
                yield return i;
                ++i;
            }
        }
    }
}
