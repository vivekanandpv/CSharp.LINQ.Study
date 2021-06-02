using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.LINQ.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> scores = new List<int> { 1, 2, 4, 7, 8, 6, 9 };

            //  what is the first number that is greater than 6?
            //  where is the filtration operator
            //  First is the sequence/element operator (terminal operator)
            int firstElement = scores.Where(s =>
            {
                Console.WriteLine($"FirstElement is executing with {s}");
                return s > 6;
            })
                 .First();
        }
    }
}
