using System;

namespace cod

{
    class Program
    {
        static void Main()
        {  
            int[,] numbers = new int[3,3];
            Random random = new Random();
           

            int sum = 0;

            int sum1 = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
               sum += numbers[i,i];
            }

             for (int i = 0; i < numbers.GetLength(1); i++)
            {
               sum1 += numbers[i,i];
            }

            sum = sum + sum1;

            System.Console.WriteLine($"Cумма {sum}");

        }
    }  
}