using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.LINQ.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> randomNumbers =
                GetSequence()
                 .Where(n =>
                 {
                     Console.WriteLine($"1st Where: {n}");
                     return n % 2 != 0;
                 })
                 .Where(n =>
                 {
                     Console.WriteLine($"2nd Where: {n}");
                     return n > 600;
                 })
                 //.Take(3) //  filtration
                 .TakeWhile(n =>    //  filtration
                 {
                     Console.WriteLine($"TakeWhile: {n}");
                     return n <= 900;   //  stops when the first non-match is found
                 })
                 .ToList(); //  conversion operator / collector
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
