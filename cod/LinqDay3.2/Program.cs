using System;
using System.Collections.Generic;
using System.Linq;

namespace cod
{
    class Program
    {
        class People
        {
            public string Name { get; set; }
            public uint Age { get; set; }
            public string City { get; set; }
        }
        static void Main()
        {
            List<People> persons = new List<People>
            {
                new People {Name = "Denis", Age = 18, City = "Berlin"},
                new People {Name = "Arsen", Age = 15, City = "Kyiv"},
                new People {Name = "Vova", Age = 24, City = "Berlin"},
                new People {Name = "Danil", Age = 23, City = "Vena"},
                new People {Name = "Alexandr", Age = 22, City = "Kyiv"},
                new People {Name = "Ivan", Age = 22, City = "Vena"}
            };

            var CityCount = persons
            .GroupBy(k => k.City)
            .Select(g => new
            {
                City = g.Key,
                Count = g.Count(),
                AverageAge = g.Average(person => person.Age)
            });

            foreach (var i in CityCount)
            {
                System.Console.WriteLine($"Город: {i.City}, Количество живущих: {i.Count}");
            }

            System.Console.WriteLine();

            var MinMax = persons
            .GroupBy(k => k.City)
            .Select(g => new
            {
                City = g.Key,
                Count = g.Count(),
                min = g.Min(i => i.Age),
                max = g.Max(i => i.Age)
            });

            foreach (var i in MinMax)
            {
                System.Console.WriteLine($"Город: {i.City}, Количество живущих: {i.Count}, Максимальный/Минимальный возраст: {i.max}, {i.min}");
            }

            System.Console.WriteLine();

            var AnonSort = persons
            .GroupBy(k => k.City)
            .Select(g => new
            {
                City = g.Key,
                Count = g.Count(),
                AverageAge = g.Average(person => person.Age)
            })
            .OrderBy(k => k.AverageAge);

            foreach (var i in AnonSort)
            {
                System.Console.WriteLine($"Город: {i.City}, Количество живущих: {i.Count}, Средний возраст живущих: {i.AverageAge}");
            }
        }
    }
}