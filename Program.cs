using System;

namespace CSharp.LINQ.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            //  creating a string array
            string[] names = new string[5]; //  traditional declaration

            //  all elements are initialized to their default values (numeric types -> 0, reference types -> null, bool -> false)
            double[] averages = new double[10];

            //  intializer syntax (verbose)
            string[] friends = new string[] { "Sujit", "Kumar", "Puja", "Raman" };

            //  initializer syntax (modern)
            string[] books = { "C# Programming Language", "Pro ASP.NET Core" };

            //  var can be used, but on the declaration we must have new type[]
            var scores = new int[] { 125, 478, 514, 714 };

            //  All arrays are reference types in C#. They inherit from Array base class
            Console.WriteLine(scores is Array);

            //  since, Array implements IEnumerable, we can use arrays in foreach
            foreach (var item in scores)
            {
                Console.WriteLine(item);
            }

            //  accessing the members of Array base class
            Console.WriteLine(books.Length);
        }
    }
}
