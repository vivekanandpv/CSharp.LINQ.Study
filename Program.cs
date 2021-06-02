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
                 .Take(20)
                 .OrderBy(n => n)   //  Key selector
                 //.OrderByDescending(n => n)   //  also possible
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
