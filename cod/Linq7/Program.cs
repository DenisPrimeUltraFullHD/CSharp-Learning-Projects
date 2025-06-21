using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 4, 7, 10, 14, 18 };

        int count = numbers.Count(n => n > 5);

        System.Console.WriteLine($"Количество чисел больше 5: {count}");

    }
}
