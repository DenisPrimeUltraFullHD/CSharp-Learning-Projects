using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Введите ваш возраст: ");
            int num = int.Parse(System.Console.ReadLine());

            string result = (num >= 18) ? "Совершеннолетний" : "Не Совершеннолетний";

            System.Console.WriteLine(result);
        }
    }
}