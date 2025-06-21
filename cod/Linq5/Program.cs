using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main()
    {
        List<int> numbers = new List<int> { 10, 12, 12, 42, 52, 15, 51, 15, 12, 53, 62, 15 };

        var unique = numbers.Distinct();
        System.Console.WriteLine("Уникальные числа:");
        foreach (var item in unique)
        {
            System.Console.WriteLine(item);
        }

    }
}
