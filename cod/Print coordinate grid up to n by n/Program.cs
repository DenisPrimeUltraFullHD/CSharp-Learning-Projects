using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Ведите число n");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    System.Console.Write($"({i},{j})\t");
                }
                System.Console.WriteLine();
            }
        }
    }
}