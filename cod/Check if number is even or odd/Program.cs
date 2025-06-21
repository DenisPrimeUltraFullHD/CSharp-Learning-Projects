using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Введите число целое число: ");
            int num = int.Parse(System.Console.ReadLine());

            string result = (num % 2 == 0) ? "Чётное" : "Нечётное";

            System.Console.WriteLine(result);
        }
    }
}