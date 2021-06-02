using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.LINQ.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            //  https://docs.microsoft.com/en-us/dotnet/api/system.linq.queryable.groupby?view=net-5.0
            var result =
                GetSequence()
                .Where(n => n % 2 == 0)
                .GroupBy(_ => "Even Numbers");

            foreach (var ge in result)
            {
                Console.WriteLine($"Group Key: {ge.Key}");

                foreach (var n in ge)
                {
                    Console.WriteLine($"Element: {n}");
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
