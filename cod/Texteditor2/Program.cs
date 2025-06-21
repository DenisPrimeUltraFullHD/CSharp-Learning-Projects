using System;

namespace cod
{
    class Program
    {
        static void Main()
        {

            string inputFile = "input.txt";
            string outputFile = "digits.txt";

            string content = File.ReadAllText(inputFile);

            Dictionary<char, int> digitsCount = new Dictionary<char, int>();

            foreach (var digit in content)
            {
                if (char.IsDigit(digit))
                {
                    if (digitsCount.ContainsKey(digit))
                    {
                        digitsCount[digit]++;
                    }
                    else
                    {
                        digitsCount[digit] = 1;
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                foreach (var pair in digitsCount)
                {
                    System.Console.WriteLine($"{pair.Key}: {pair.Value}");
                }
            }
            System.Console.WriteLine("Всё сделано");
        }
    }
}