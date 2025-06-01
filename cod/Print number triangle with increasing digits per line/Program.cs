using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write(j);
                }
                System.Console.WriteLine();
            }
        }
    }
}