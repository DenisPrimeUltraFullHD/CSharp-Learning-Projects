using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            int a, b, res;

            try

            {

                Console.WriteLine("Введите первое число: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите Второе число: ");
                b = Convert.ToInt32(Console.ReadLine());
                res = a / b;
                Console.WriteLine("Последствия деления " + res);

            }

            catch (DivideByZeroException)
            {
                System.Console.WriteLine("НЕЛЬЗЯ ДЕЛИТЬ НА 0");
            }

        }
    }
}
