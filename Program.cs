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
                 .Take(5)
                 .Where(n =>
                 {
                     Console.WriteLine($"Sequence: {n}");
                     return n > 0;
                 })
                 .Reverse() // reverses the order of elements
                 .ToArray(); //  conversion operator / collector
        }

        static IEnumerable<int> GetSequence()
        {
            Random random = new Random();

            while (true)
            {
                yield return random.Next(100, 1000);
            }
        }
    }
}
