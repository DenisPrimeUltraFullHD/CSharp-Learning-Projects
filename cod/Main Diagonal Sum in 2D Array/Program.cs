using System;

namespace cod

{
    class Program
    {
        static void Main()
        {

            int[,] mass = new int[4, 4];

            Random random = new Random();

            int sum = 0;

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = random.Next(0, 50);
                }
            }

            {
                for (int k = 0; k < mass.GetLength(0); k++)

                {
                    sum += mass[k, k];
                }

            }

            System.Console.WriteLine($"Сумма цифр главной диагонали: {sum}");
        }
    }
}
