using System;

namespace cod

{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число (от 1 до 7): ");
            short a = Convert.ToInt16(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Понеділок "); break;
                case 2:
                    Console.WriteLine("Вівторок "); break;
                case 3:
                    Console.WriteLine("Середа "); break;
                case 4:
                    Console.WriteLine("Четверг "); break;
                case 5:
                    Console.WriteLine("П'ятниця "); break;
                case 6:
                    Console.WriteLine("Суббота "); break;
                case 7:
                    Console.WriteLine("Неділя "); break;
                default:
                    Console.WriteLine("Ошибка: введите число от 1 до 7."); break;
            }
        }
    }
}