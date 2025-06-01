using System;

namespace cod

{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {

                int s = a * i;

                Console.WriteLine($"Відповідь {s}");

            }
        }
    }
}
