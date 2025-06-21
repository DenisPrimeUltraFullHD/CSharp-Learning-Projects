using System;
using System.IO;
using System.Threading.Tasks;

namespace cod
{
    class Program
    {
        static async Task Main()
        {

            string file1 = "input1.txt";
            string file2 = "input2.txt";
            string file3 = "input3.txt";

            Task<string> read1 = File.ReadAllTextAsync(file1);
            Task<string> read2 = File.ReadAllTextAsync(file2);
            Task<string> read3 = File.ReadAllTextAsync(file3);

            string[] contents = await Task.WhenAll(read1, read2, read3);

            int num = 0;

            for (int i = 0; i <= contents.Length; i++)
            {
                int length = contents[i].Length
                System.Console.WriteLine($"Файл {i + 1}   Количество символов: {content.Length} ");
                num += length;
            }

            System.Console.WriteLine($"Количество символов во всех файлах: {num}");

        }
    }
}