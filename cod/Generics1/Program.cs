using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> words = new List<string>()
        {
            "apple",
            "banana",
            "kiwi",
            "peach",
            "plum"
        };
        Dictionary<string, int> wordLengths = new Dictionary<string, int>();
        foreach (string word in words)
        {
            wordLengths[word] = word.Length;
        }

        System.Console.WriteLine("Слово -> Длина: ");
        foreach (var pair in wordLengths)
        {
            System.Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }

        HashSet<int> uniqueLengths = new HashSet<int>();
        foreach (var length in wordLengths.Values)
        {
            uniqueLengths.Add(length);
        }

        System.Console.WriteLine("\nУникальные длины слов:");
        foreach (var len in uniqueLengths)
        {
            System.Console.WriteLine(len);
        }
    }
}
