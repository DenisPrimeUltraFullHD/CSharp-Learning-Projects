using System;

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
                new People {Name = "Danil", Age = 23, City = "Viena"},
                new People {Name = "Alexandr", Age = 22, City = "Kyiv"},
                new People {Name = "Ivan", Age = 22, City = "Viena"},
            };

            var Over18 = persons
            .Where(k => k.Age >= 18)
            .Where(k => k.City == "Kyiv")
            .OrderBy(k => k.Name)
            .Select(k => new { k.Name, k.City });

            foreach (var item in Over18)
            {
                System.Console.WriteLine($"Имя: {item.Name}, Город: {item.City}");
            }

            var Citys = persons
            .OrderBy(k => k.City)
            .Select(k => new { k.City })
            .Distinct();

            System.Console.WriteLine("\n");

            foreach (var item in Citys)
            {
                System.Console.WriteLine($"Город: {item.City}");
            }

            var FirstAName = persons
            .Where(k => k.Name.StartsWith("A"))
            .FirstOrDefault();

            System.Console.WriteLine("\n");

            System.Console.Write($"Первое имя на 'А' {FirstAName.Name}");

            System.Console.WriteLine("\n");

            var toUpper = persons
            .Select(k => k.Name.ToUpper())
            .ToArray();
            foreach (var item in toUpper)
            {
                System.Console.WriteLine($"Имя: {item}");
            }
        }
    }
}