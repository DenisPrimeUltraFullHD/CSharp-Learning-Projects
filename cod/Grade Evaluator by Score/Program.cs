using System;

namespace cod

{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите вашу оценку: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < 0)
                Console.WriteLine("Error");
            if (a > 100)
                Console.WriteLine("Error");

            if (a >= 90)
                Console.WriteLine("Отличный результат");
            else if ((a >= 80) && (a <= 89))
                Console.WriteLine("Хороший результат");
            else if ((a >= 70) && (a <= 79))
                Console.WriteLine("Удовлетворительный результат");
            else
                Console.WriteLine("Плохой результат");
        }
    }
}
