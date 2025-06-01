using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Ведите сколько долларов хотите обменять на гривны");
            int dols = int.Parse(Console.ReadLine());

            double res = 41.10 * dols;

            System.Console.WriteLine($"Количество обмениваемых гривен: {res}");
        }
    }
}