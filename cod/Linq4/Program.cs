using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main()
    {
        List<int> numbers = new List<int> { 10, 2, 3, 4, 5, 6, 7, 12, 16, 13, 36 };

        int max = numbers.Max();
        int min = numbers.Min();

        System.Console.WriteLine($"Максимальное число: {max}");

        System.Console.WriteLine($"Минимальное число: {min}");

    }
}
