using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            int count = 0;

            int[][] Array = new int[4][];

            Array[0] = new int[2];
            Array[1] = new int[3];
            Array[2] = new int[5];
            Array[3] = new int[4];

            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array[i].Length; j++)
                {
                    System.Console.WriteLine($"Введите число массива {i},{j}: ");
                    Array[i][j] = int.Parse(Console.ReadLine());

                }
            }
            System.Console.WriteLine("Массив");
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array[i].Length; j++)
                {
                    System.Console.Write($"{Array[i][j]}\t");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("Обёрнутый массив");
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = Array[i].Length - 1; j >= 0; j--)
                {
                    System.Console.Write(Array[i][j] + "\t");
                }
                System.Console.WriteLine();
            }
        }
    }
}