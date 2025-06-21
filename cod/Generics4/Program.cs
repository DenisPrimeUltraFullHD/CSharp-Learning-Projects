using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> words = new List<string> { "Яблоко", "Банан", "Киви", "Ананас", "Мандарин" };
        foreach (var word in words)
        {
            if (word.Length > 5)
            {
                System.Console.WriteLine("Длинное слово:" + word);
            }
        }
    }
}
