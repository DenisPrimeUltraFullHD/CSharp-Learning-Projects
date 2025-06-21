using System;
using System.Collections.Generic;
using System.Linq;

namespace cod
{
    class Program
    {
        private class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Country { get; set; }
        }
        static void Main()
        {
            List<Person> person = new List<Person>
            {
                new Person {Name = "Denis", Age = 18, Country = "Ukraine"},
                new Person {Name = "Maxim", Age = 17, Country = "Ukraine"},
                new Person {Name = "Stepan", Age = 20, Country = "Ukraine"},
                new Person {Name = "Arsen", Age = 17, Country = "Russia"},
                new Person {Name = "Anna", Age = 19, Country = "Russia"},
                new Person {Name = "Ivan", Age = 20, Country = "Russia"},
                new Person {Name = "William", Age = 17, Country = "Germany"},
                new Person {Name = "Adolf", Age = 45, Country = "Austria"},
                new Person {Name = "Ronald", Age = 20, Country = "Usa"}
            };

            var stats = person
            .GroupBy(p => p.Country)
            .Select(g => new
            {
                Country = g.Key,
                Names = g.Select(p => p.Name).ToArray()
            });

            foreach (var stat in stats)
            {
                System.Console.WriteLine($"\n{stat.Country}:");

                foreach (var name in stat.Names)
                {
                    System.Console.Write($"[{name}]");
                }
            }
        }
    }
}