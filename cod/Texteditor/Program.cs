using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";

        try
        {
            string content = File.ReadAllText(inputFilePath);

            string[] words = content.Split(
                new char[] { ' ', '\n', '\r', '\t', '.', ',', '!', '?', ';', ':', '(', ')', '\"' },
                StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string cleanedWord = word.ToLower();
                if (wordCount.ContainsKey(cleanedWord))
                    wordCount[cleanedWord]++;
                else
                    wordCount[cleanedWord] = 1;
            }

            var sortedWords = wordCount.OrderByDescending(pair => pair.Value);

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var pair in sortedWords)
                {
                    writer.WriteLine($"{pair.Key}: {pair.Value}");
                }
            }

            Console.WriteLine("Готово. Результаты записаны в output.txt.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}
