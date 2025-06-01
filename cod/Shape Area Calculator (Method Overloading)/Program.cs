using System;

namespace cod
{
    class Program
    {
        public static double ShapeArea(double a)
        {
            double d = Math.Pow(a, 2);
            Console.WriteLine($"Площадь квадрата: {d}");
            return d;
        }

        public static double ShapeArea(double a, double b)
        {
            double s = a * b;
            Console.WriteLine($"Площадь прямоугольника: {s}");
            return s;
        }

        static void Main()
        {
            Console.WriteLine("Введите количество параметров (1 для квадрата, 2 для прямоугольника): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Введите длину стороны квадрата: ");
                double side = Convert.ToDouble(Console.ReadLine());
                ShapeArea(side);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Введите ширину прямоугольника: ");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите высоту прямоугольника: ");
                double height = Convert.ToDouble(Console.ReadLine());

                ShapeArea(width, height);
            }
            else
            {
                Console.WriteLine("Ошибка: Введите 1 или 2.");
            }
        }
    }
}
