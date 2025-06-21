using System;

namespace cod

{
    class Program
    {
        static void Main()
        {  
            Console.WriteLine("Длина: ");
                double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ширина: ");
                double b = Convert.ToDouble(Console.ReadLine());

                double s;

            s = a * b;

            Console.WriteLine($"Площадь: {s}");

            s = 2 * (a + b);

            Console.WriteLine($"Периметр: {s}");

        }
    }   
}