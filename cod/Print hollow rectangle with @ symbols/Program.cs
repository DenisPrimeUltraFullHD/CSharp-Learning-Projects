using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 1 || i == 5)
                {
                    for (int j = 0; j <= 4; j++)
                    {
                        System.Console.Write("@");

                    }
                }
                else if (i == 2 || i == 3 || i == 4)
                {
                    for (int j = 1; j <= 1; j++)
                    {
                        System.Console.Write($"@   @");

                    }
                }
                System.Console.WriteLine();
            }
        }
    }
}