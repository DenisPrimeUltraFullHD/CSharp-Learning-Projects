using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var words = new List<string> { "apple", "banana", "pear", "plum", "peach" };

        var longWords = words.Where(w => w.Length > 4);
        System.Console.WriteLine("Слова длиннее 4 символов: ");
        foreach (var word in longWords)
            System.Console.WriteLine(word);

        var sorted = words.OrderBy(w => w);
        System.Console.WriteLine("\nОтсортировано по алфавиту:");
        foreach (var word in sorted)
        {
            System.Console.WriteLine(word);
        }

    }
}
