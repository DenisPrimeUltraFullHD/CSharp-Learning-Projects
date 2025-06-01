using System;

namespace cod
{
    class Program
    {
        static bool IsEven(double num)
        {
            if (num % 2 == 0)
            {
                System.Console.WriteLine($"Число {num} чётное ");
                return true;
            }
            else
            {
                System.Console.WriteLine($"Число {num} не чётное ");
                return false;
            }
        }
        static void Main()
        {
            System.Console.WriteLine("Введите число: ");
            double num = double.Parse(Console.ReadLine());

            bool iseven = IsEven(num);
        }
    }
}