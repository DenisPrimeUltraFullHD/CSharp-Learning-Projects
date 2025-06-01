using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            int[,] mass =
            {
                { 1, 2, 3},
                { 5, 6, 7},
                { 9, 10, 11},
                { 13, 14, 15}

            };
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    sum += mass[i, j];
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}