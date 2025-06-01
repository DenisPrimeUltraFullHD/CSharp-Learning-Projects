using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                System.Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}