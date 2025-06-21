using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            int pair = 0;
            int[] mass = { 123, 45, 204, 54, 24, 354, 67, 404, 22, 10 };
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 2 == 0)
                {
                    pair++;
                }
            }
            System.Console.WriteLine($"Всего чётных чисел {pair}");
        }
    }
}