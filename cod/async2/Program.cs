using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            int num = 0;

            for (int i = 1; i <= 3; i++)
            {
                string inputFile = $"input{i}.txt";
                string content = File.ReadAllText(inputFile);
                System.Console.WriteLine($"Количество символов: {content.Length} ");
                num += content.Length;
            }

            System.Console.WriteLine($"Количество символов во всех файлах: {num}");

        }
    }
}