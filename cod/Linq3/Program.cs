using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main()
    {

        List<string> fruits = new List<string> { "apple", "apricot", "banana", "blueberry", "cherry" };

        var groups = fruits.GroupBy(f => f[0]);

        foreach (var group in groups)
        {
            System.Console.WriteLine($"Буква: {group.Key}");

            foreach (var fruit in group)
            {
                System.Console.WriteLine(" " + fruit);
            }
        }

    }
}
