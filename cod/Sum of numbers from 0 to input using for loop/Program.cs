using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Введите число");
            int length = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i <= length; i++)
            {
                sum += i;
            }

            System.Console.WriteLine($"Сума чисел: {sum}");
        }
    }
}