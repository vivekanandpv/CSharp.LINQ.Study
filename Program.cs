using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.LINQ.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            //  concatenates two sequences (second starts after first finishes)
           int[] combined = GetSequence1().Concat(GetSequence2()).ToArray();
        }

        static IEnumerable<int> GetSequence1()
        {
            int i = 1;

            while (i <= 10)
            {
                yield return i;
                ++i;
            }
        }

        static IEnumerable<int> GetSequence2()
        {
            int i = 100;

            while (i >= 90)
            {
                yield return i;
                --i;
            }
        }
    }
}
