using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            int input = 0;
            int password = 0;

            System.Console.WriteLine("Введите пароль");

            while (password != 1234)
            {
                input = int.Parse(Console.ReadLine());

                password = input;
            }
            System.Console.WriteLine($"Доступ разрешен");
        }
    }
}