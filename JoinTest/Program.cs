using System;
using System.Collections.Generic;
using System.Linq;

namespace JoinTest
{
    internal class Program
    {
        private static IEnumerable<Employee> Employees
        {
            get
            {
                yield return new Employee {Id = "1", Name = "Alice"};
                yield return new Employee {Id = "2", Name = "Bob"};
            }
        }

        private static IEnumerable<Retiree> Retirees
        {
            get
            {
                yield return new Retiree {Id = "2", Pension = 33};
                yield return new Retiree {Id = "3", Pension = 44};
            }
        }

        private static void Main(string[] args)
        {
            var joined = from employee in Employees
                join retiree in Retirees
                    on employee.Id equals retiree.Id
                select
                    new {employee.Name, retiree.Pension};
            foreach (var item in joined)
            {
                Console.WriteLine(item.Name + " " + item.Pension);
            }
            var leftJoined = from employee in Employees
                join retiree in Retirees on employee.Id equals retiree.Id into temp
                from x in temp.DefaultIfEmpty()
                select new {employee.Name, x?.Pension};
            foreach (var item in leftJoined)
            {
                Console.WriteLine(item.Name + " " + item.Pension);
            }
            Console.Read();
        }
    }

    internal class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    internal class Retiree
    {
        public string Id { get; set; }
        public double Pension { get; set; }
    }
}