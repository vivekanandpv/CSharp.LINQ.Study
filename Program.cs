using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.LINQ.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers =
                GetSequence()
                 .Where(n =>
                 {
                     Console.WriteLine($"Sequence Before: {n}");
                     return n > 0;
                 })
                 .SkipWhile(n =>
                 {
                     Console.WriteLine($"SkipWhile: {n}");
                     return n > 400;    //  keep skipping until the first non-match is found
                                        //  once the first non-match is found, this filter is not applied
                 })
                 .Where(n =>
                 {
                     Console.WriteLine($"Sequence After: {n}");
                     return n > 0;
                 })
                 .ToArray();
        }

        static IEnumerable<int> GetSequence()
        {
            Random random = new Random();

            int i = 0;

            while (i < 10)
            {
                yield return random.Next(100, 1000);
                ++i;
            }
        }
    }
}
