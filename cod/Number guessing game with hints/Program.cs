using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int number = -1;
            int answer = rnd.Next(0, 100);

            System.Console.WriteLine("Введите число");

            while (number != answer)
            {
                number = int.Parse(Console.ReadLine());

                if (number < answer)
                {
                    System.Console.WriteLine("Меньше заданного числа!!!");
                    number = -1;
                }
                else if (number > answer)
                {
                    System.Console.WriteLine("Больше заданного числа!!!");
                    number = -1;
                }
                else if (number <= answer || number >= answer || number == answer)
                {
                    System.Console.WriteLine("Угадал");
                    break;
                }
            }
        }
    }
}