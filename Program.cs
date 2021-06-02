using System;
using System.Collections.Generic;

namespace CSharp.LINQ.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> coll = GetNumbers();
            
            foreach (var n in coll)
            {
                Console.WriteLine(n);
            }
        }

        //  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield
        static IEnumerable<int> GetNumbers()
        {
            Console.WriteLine("GetNumbers is called");
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("inside the generator");
                yield return random.Next();
            }
        }
    }
}
