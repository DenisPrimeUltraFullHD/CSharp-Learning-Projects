using System;
using System.IO;

namespace cod
{
    class Program
    {
        public static void Main()
        {

            try
            {
                string word = System.Console.ReadLine();

                int num = int.Parse(word);

                double equal = num * num;

                System.Console.WriteLine($"Квадрат числа {num} равен {equal} ");
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Неверный формат!!!");
            }
        }
    }
}
