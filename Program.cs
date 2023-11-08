using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.LINQ.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>
            {
                new Person {FullName="Rajan Mishra", PersonId=2},
                new Person {FullName="Ramesh Kumar", PersonId=3},
                new Person {FullName="Manas Chandra", PersonId=5},
            };

            List<Car> cars = new List<Car>
            {
                new Car {RegistrationNumber=4478, PersonId=2},
                new Car {RegistrationNumber=5689, PersonId=3},
                new Car {RegistrationNumber=7750, PersonId=5},
            };

            List<string> joined =
                 persons
                 .Join(
                     cars,
                     p => p.PersonId,
                     c => c.PersonId,
                     (p, c) => $"Person: {p.FullName} Registration Number: {c.RegistrationNumber}"
                     )
                 .ToList();
        }
    }

    class Person
    {
        public int PersonId { get; set; }
        public string FullName { get; set; }
    }

    class Car
    {
        public int RegistrationNumber { get; set; }
        public int PersonId { get; set; }
    }
}
