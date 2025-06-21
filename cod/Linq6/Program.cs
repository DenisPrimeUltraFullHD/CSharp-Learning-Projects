using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main()
    {
        List<string> cities = new List<string> { "Kyiv", "Lviv", "Odessa", "Dnipro", "Kharkiv" };

        var firsThree = cities.Take(3);

        System.Console.WriteLine("Первые 3 города:");
        foreach (var city in firsThree)
        {
            System.Console.WriteLine(city);
        }
    }
}
