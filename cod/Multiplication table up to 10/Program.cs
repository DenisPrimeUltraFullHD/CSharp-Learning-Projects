using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            int number = 0;
            System.Console.WriteLine("Ведите число");
            int input = int.Parse(Console.ReadLine());

            while (number < 10)
            {
                number++;
                System.Console.WriteLine($"{input} * {number} = {input * number}");
            }
        }
    }
}