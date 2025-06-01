using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            int[] mass = { 123, 45, 204, 54, 24, 354, 67, 404, 22, 10 };

            int[] new_mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                new_mass[i] = mass[i] * 2;
            }
            for (int j = 0; j < mass.Length; j++)
            {
                Console.WriteLine($"Старое: {mass[j]}\t Новое: {new_mass[j]}");
            }
        }
    }
}