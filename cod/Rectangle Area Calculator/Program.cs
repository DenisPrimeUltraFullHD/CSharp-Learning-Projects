using System;

namespace cod
{
    class Program
    {
        static double CalculateRectangleArea(double Width, double Long)
        {
            return Width * Long;
        }
        static void Main()
        {
            System.Console.WriteLine("Введите ширину фигуры: ");
            double _width = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Введите длину фигуры: ");
            double _long = double.Parse(Console.ReadLine());

            double result = CalculateRectangleArea(_width, _long);
            System.Console.WriteLine($"Площадь фигуры: " + result);
        }
    }
}