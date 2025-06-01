using System;

namespace cod
{
    class Program
    {

        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main()
        {

            System.Console.WriteLine("Введите день недели: (Число от 1 до 7)");
            int Week_d = Convert.ToInt32(Console.ReadLine());

            DayOfWeek day = (DayOfWeek)Week_d;
            switch (day)
            {


                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    System.Console.WriteLine("Рабочий день");
                    break;

                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    System.Console.WriteLine("Выходной день");
                    break;

            }
        }
    }
}