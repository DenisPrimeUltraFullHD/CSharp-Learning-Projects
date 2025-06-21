using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main()
    {
        List<string> names = new List<string> { "denys", "ivan", "masha" };

        var upperNames = names.Select(name => name.ToUpper()).ToList();

        foreach (var name in upperNames)
        {
            System.Console.WriteLine(name);
        }

    }
}
