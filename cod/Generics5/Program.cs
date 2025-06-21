using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> wordLengths = new Dictionary<string, int>();

        foreach (var word in words)
        {
            wordLengths[word] = word.Length;
        }
        foreach (var pair in wordLengths)
        {
            System.Console.WriteLine($"{pair.Key} --> {pair.Value}");
        }
    }
}
