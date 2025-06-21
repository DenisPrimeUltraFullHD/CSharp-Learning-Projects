using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Ведите число");
            int count = int.Parse(Console.ReadLine());
            int number = 0;
            while (count > 0)
            {
                number++;
                count = count / 10;
            }
            System.Console.WriteLine($"Количество чисел {number}");
        }
    }
}