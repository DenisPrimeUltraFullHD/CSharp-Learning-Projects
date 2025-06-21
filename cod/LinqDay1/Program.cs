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
                new Person{Name="Maxim", Age = 17, City="Oslo"},
                new Person{Name="Ksysha", Age = 19, City="Moskow"},
                new Person{Name="Alexandr", Age = 16, City="Kazan"},
                new Person{Name="Shirou", Age = 19, City="Fuyuuki"}
            };
            System.Console.WriteLine("Peoples Lived most that 17 years");
            var adults = people.Where(p => p.Age > 17);

            foreach (var person in adults)
            {
                System.Console.WriteLine($"{person.Name}, {person.Age} years old, lives in {person.City}");
            }
        }
    }
}