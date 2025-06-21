using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            int[,] mass =
            {
                { 1, 2, 3, 4},
                { 5, 6, 7, 8},
                { 9, 10, 11, 12}
            };
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    System.Console.Write($"{mass[i, j]}\t");
                }
                System.Console.WriteLine();
            }
        }
    }
}