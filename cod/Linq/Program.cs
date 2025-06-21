using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 4, 7, 10, 15, 3, 6 };

        var filtered = numbers.Where(n => n > 5).ToList();
        foreach (var n in filtered)
        {
            System.Console.WriteLine(n);
        }

    }
}
