using System;

namespace cod

{
    class Program
    {
        static void Main()
        {  
            Console.WriteLine("Первая переменная: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вторая переменная: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Третья переменная: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int result = (a + b) * c / 2;

            Console.WriteLine($"Результат: {result}");
        }
    }   
}