using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.LINQ.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Aggregate operators produce singularlities
            int max = GetSequence().Max();              //  beware of infinite sequence
            int min = GetSequence().Min();              //  beware of infinite sequence
            int sum = GetSequence().Sum();              //  sequence must be numeric (int, double, decimal) or conversion required
            double average = GetSequence().Average();   //  sequence must be numeric (int, double, decimal) or conversion required

            int sumReducerNoSeed = GetSequence().Aggregate((a, b) => a + b);        //  reducer
            int sumReducerWithSeed = GetSequence().Aggregate(0, (a, b) => a + b);   //  reducer with seed
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
