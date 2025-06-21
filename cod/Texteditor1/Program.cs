using System;

namespace cod
{
    class Program
    {
        static void Main()
        {

            string inputFile = "input.txt";
            string outputFile = "letter.txt";

            string content = File.ReadAllText(inputFile);

            string[] words = content.Split(
                new char[] { ' ', '\n', '\t', '\r', '.', ',', '!', '?', ':', ';', '!', '(', ')', '\"' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char letter in content)
            {
                if (char.IsLetter(letter))
                {
                    char lover = char.ToLower(letter);
                    if (letterCount.ContainsKey(lover))
                    {
                        letterCount[lover]++;
                    }
                    else
                    {
                        letterCount[lover] = 1;
                    }
                }
            }

            var sortedLetters = letterCount.OrderByDescending(pair => pair.Value);

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                foreach (var pair in sortedLetters)
                {
                    writer.WriteLine($"{pair.Key}: {pair.Value}");
                }
            }
            System.Console.WriteLine("Всё готово");
        }
    }
}