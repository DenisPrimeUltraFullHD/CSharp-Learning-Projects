using System;

namespace cod
{
    class Program
    {
        static string Custom(string element, int repeat)
        {
            string result1 = "";

            for (int i = 0; i < repeat; i++)
            {
                result1 += element;
            }
            return result1;
        }
        static void Main()
        {
            System.Console.WriteLine("Введите желаемый символ для строки: ");
            string el = Console.ReadLine();
            System.Console.WriteLine("Введите длину строки: ");
            int rep = int.Parse(Console.ReadLine());

            string result = Custom(el, rep);
            Console.WriteLine(result);
        }
    }
}