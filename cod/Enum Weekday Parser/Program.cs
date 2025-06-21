using System;

namespace cod
{
    enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {

        static void PrintDay(WeekDay day)
        {
            System.Console.WriteLine($"Сегодня: {day}");
        }

        static void Main()
        {
            System.Console.WriteLine("Введите день недели: ");
            string input = Console.ReadLine();

            if (Enum.TryParse<WeekDay>(input, true, out WeekDay day))
            {
                PrintDay(day);
            }
            else
            {
                System.Console.WriteLine("Ошибка: неизвестный день недели");
            }
        }
    }
}