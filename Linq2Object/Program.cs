using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace Linq2Object
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var people = new List<Employee>
            {
                new Employee {Name = "Alice", Gender = Gender.Female, Rating = 5, Region = "CA", Salary = 1000000},
                new Employee {Name = "Bob", Gender = Gender.Female, Rating = 2, Region = "NY", Salary = 120000},
                new Employee {Name = "Charlie", Gender = Gender.Male, Rating = 3, Region = "CA", Salary = 400000},
                new Employee {Name = "David", Gender = Gender.Male, Rating = 4, Region = "NY", Salary = 5000000},
                new Employee {Name = "Eric", Gender = Gender.Male, Rating = 5, Region = "WA", Salary = 700000},
                new Employee {Name = "Frank", Gender = Gender.Male, Rating = 6, Region = "NY", Salary = 1800000},
                new Employee {Name = "George", Gender = Gender.Male, Rating = 2, Region = "CA", Salary = 1040000},
                new Employee {Name = "Helen", Gender = Gender.Female, Rating = 3, Region = "Ny", Salary = 20000},
                new Employee {Name = "Isabelle", Gender = Gender.Female, Rating = 4, Region = "WA", Salary = 150000},
                new Employee {Name = "Jack", Gender = Gender.Male, Rating = 6, Region = "CA", Salary = 60000}
            };
            var averageRating = people.Select(p => p.Rating).Average();
            var averageFemaleRating = people.Where(p => p.Gender == Gender.Female).Select(p => p.Rating).Average();
            var averageSalaryOfTopFemaleEmployees =people.Where(p => p.Gender == Gender.Female).OrderByDescending(p => p.Salary).Take(3).Average(p => p.Salary);

            //select salary, name from people where gender = femaly order by salary desecending limit 3;
            var topFemale = from p in people where p.Gender == Gender.Female orderby p.Salary descending select new {p.Name, p.Salary};
           /* foreach (var p in topFemale.Take(3))
            {
                Console.WriteLine("{0} {1}", p.Name, p.Salary);
            }*/
            Console.WriteLine(string.Join("\n", topFemale.Take(3).Select(p => $"{p.Name} {p.Salary}")));
            Console.Read();
        }
    }
}