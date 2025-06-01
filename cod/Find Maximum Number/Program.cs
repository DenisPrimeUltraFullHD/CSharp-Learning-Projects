using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            int max = 0;
            int[] mass = { 123, 45, 204, 54, 24, 354, 67 };

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] >= max)
                {
                    max = mass[i];
                }
            }
            System.Console.WriteLine($"Cамое большое число массива это {max}");
        }
    }
}