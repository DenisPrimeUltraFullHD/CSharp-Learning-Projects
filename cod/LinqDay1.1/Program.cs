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
                new Person{Name="Alice", Age = 20, City="Kyiv"},
                new Person{Name="Denis", Age = 18, City="Cherkassy"},
                new Person{Name="Senya", Age = 17, City="Izhevsk"},
                new Person{Name="Maxim", Age = 17, City="Kyiv"},
                new Person{Name="Ksysha", Age = 19, City="Moscow"},
                new Person{Name="Alexandr", Age = 16, City="Kyiv"},
                new Person{Name="Shirou", Age = 19, City="Fuyuuki"}
            };

            var kyivResidents = people
                .Where(p => p.City == "Kyiv")
                .Select(p => p.Name.ToUpper());

            foreach (var name in kyivResidents)
            {
                System.Console.WriteLine(name);
            }
        }
    }
}