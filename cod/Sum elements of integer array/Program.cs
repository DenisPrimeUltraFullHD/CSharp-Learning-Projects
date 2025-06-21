using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            int[] mass = { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < mass.Length; i++)
            {
                sum += mass[i];
            }

            System.Console.WriteLine(sum);
        }
    }
}