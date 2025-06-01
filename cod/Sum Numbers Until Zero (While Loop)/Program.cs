using System;

namespace cod

{
    class Program
    {
        static void Main()
        {
            int a = 0;

            Console.WriteLine("Введите число: ");
            int i = Convert.ToInt32(Console.ReadLine());

            while (i != 0)
            {

                a += i;

                Console.WriteLine("Введите число (0 для завершения): ");
                i = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine($"Cумма чисел {a}");
        }
    }
}
