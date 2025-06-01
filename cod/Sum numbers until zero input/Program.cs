using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            int input = -1;
            System.Console.WriteLine("Введите число чтобы поучить сумму чисел");

            while (input != 0)
            {
                input = int.Parse(Console.ReadLine());

                sum = input + sum;
            }
            System.Console.WriteLine($"Сумма: {sum}");
        }
    }
}
