using System;
using System.Collections.Generic;
using System.Linq;

namespace cod
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

    }
    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>
            {
                new Person{Name="Alice", Age = 20, City="Fuyuki"},
                new Person{Name="Denis", Age = 18, City="Cherkassy"},
                new Person{Name="Senya", Age = 17, City="Fuyuki"},
                new Person{Name="Maxim", Age = 17, City="Cherkassy"},
                new Person{Name="Ksysha", Age = 19, City="Izhevsk"},
                new Person{Name="Alexandr", Age = 16, City="Fuyuki"},
                new Person{Name="Shirou", Age = 19, City="Izhevsk"}
            };

            var FuyukiSort = people
                .Where(p => p.City == "Fuyuki")
                .OrderByDescending(p => p.Name)
                .Select(p => p.Name.ToLower());

            foreach (var name in FuyukiSort)
            {
                System.Console.WriteLine(name);
            }
        }
    }
}