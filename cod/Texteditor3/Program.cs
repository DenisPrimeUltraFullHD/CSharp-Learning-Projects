using System;

namespace cod
{
    class Program
    {
        static void Main()
        {

            string inputFile = "input.txt";
            string outputFile = "unique_sorted.txt";

            string text = File.ReadAllText(inputFile);

            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t', ',', '.', '!', '?', ';', ':', '"', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            var sortedWords = words
            .Select(w => w.ToLower())
            .Distinct()
            .OrderBy(p => p);

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                foreach (var item in sortedWords)
                {
                    writer.WriteLine($"{item}");
                }
            }
            System.Console.WriteLine("Задача выполнена!!");
        }
    }
}