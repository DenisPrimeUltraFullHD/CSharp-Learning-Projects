using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    System.Console.Write(" ");
                    for (int k = 0; k < n; k++)
                    {
                        System.Console.Write("*");
                    }
                }
                System.Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
    }
}