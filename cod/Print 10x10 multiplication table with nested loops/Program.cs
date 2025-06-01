using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                System.Console.WriteLine();

                for (int j = 1; j <= 10; j++)
                {
                    System.Console.Write($"\t{j} * {i} = {j * i} ");
                }
            }
        }
    }
}