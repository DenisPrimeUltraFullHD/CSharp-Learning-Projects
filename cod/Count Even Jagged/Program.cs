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
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array[i].Length; j++)
                {
                    if (Array[i][j] % 2 == 0)
                    {
                        count++;
                    }
                }

            }
            System.Console.WriteLine("Количество чётных чисел: " + count);
        }
    }
}