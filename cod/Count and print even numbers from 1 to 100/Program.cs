using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            int countofpairs = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                    countofpairs++;

                }
            }
            System.Console.WriteLine("Количество парных чисел " + countofpairs);
        }
    }
}