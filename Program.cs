using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.LINQ.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result1 = GetSequence().All(n => n % 2 == 0);  //  are all elements of the sequence even?
            bool result2 = GetSequence().Any(n => n == 10);      //  is there any element that is 10?
            bool result3 = GetSequence().Contains(5);           //  does this sequence contain value 5?
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
