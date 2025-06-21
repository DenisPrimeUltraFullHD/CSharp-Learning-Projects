using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace cod
{
    class Program
    {
        static void Main()
        {
            string inputFile = "input.txt";
            string outputFile = "word_lengths.txt";

            string content = File.ReadAllText(inputFile);
            string[] words = content.Split(
                new char[] { ' ', '\n', '\t', '\r', '.', ',', '!', '?', ':', ';', '(', ')', '\"' },
                StringSplitOptions.RemoveEmptyEntries
            );

            Dictionary<int, int> wordLengths = new Dictionary<int, int>();

            foreach (var word in words)
            {
                int length = word.Length;

                if (wordLengths.ContainsKey(length))
                {
                    wordLengths[length]++;
                }
                else
                {
                    wordLengths[length] = 1;
                }
            }

            var sorted = wordLengths.OrderBy(p => p.Key);

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                foreach (var item in sorted)
                {
                    writer.WriteLine($"Слов длины {item.Key}: {item.Value}");
                }
            }

            Console.WriteLine("Задача выполнена!");
        }
    }
}
