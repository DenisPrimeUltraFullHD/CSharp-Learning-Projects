using System;

namespace cod
{
    class Program
    {
        static async Task Main()
        {
            int num = 0;
            string file1 = "input1.txt";
            string file2 = "input2.txt";
            string file3 = "input3.txt";

            Task<string> read1 = File.ReadAllTextAsync(file1);
            Task<string> read2 = File.ReadAllTextAsync(file2);
            Task<string> read3 = File.ReadAllTextAsync(file3);

            string[] content = await Task.WhenAll(read1, read2, read3);

            int totalChars = 0;
            int totalLines = 0;

            for (int i = 0; i < content.Length; i++)
            {
                string content = contents[i];
                int charCount = content.Length;
                int lineCount = content.Split('\n').Length;

                totalChars += charCount;
                totalLines += lineCount;

                System.Console.WriteLine($"Файл {i + 1}: {charCount} символов, {lineCount}строк");
            }
            System.Console.WriteLine($"Общее количество символов и строк {totalChars}, {totalLines}");
        }
    }
}