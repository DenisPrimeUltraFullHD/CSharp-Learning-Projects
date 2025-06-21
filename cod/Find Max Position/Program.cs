using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            int[,] mass =
            {
                { 123, 241},
                { 513, 645},
                { 91, 105},
                { 123, 143},
                { 617, 418}

            };
            int max_pos1 = 0;
            int max_pos2 = 0;
            int max = mass[0, 0];
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (max < mass[i, j])
                    {
                        max = mass[i, j];
                        max_pos1 = i;
                        max_pos2 = j;
                    }
                }
            }
            System.Console.WriteLine($"Позиция максимального числа {max}: {max_pos1}, {max_pos2} ");
        }
    }
}