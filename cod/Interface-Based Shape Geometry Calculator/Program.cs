using System;
using System.Collections.Generic;

namespace cod
{
    interface IShape
    {
        double GetArea();
        double GetPerimeter();
    }
    class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Rectangle : IShape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public double GetArea()
        {
            double s = GetPerimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
    }

    class Program
    {
        static void PrintShapesInfo(List<IShape> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Тип: {shape.GetType().Name}");
                Console.WriteLine($"Площадь: {shape.GetArea():F2}");
                Console.WriteLine($"Периметр: {shape.GetPerimeter():F2}");
                Console.WriteLine(new string('-', 30));
            }
        }

        static void Main(string[] args)
        {
            var shapes = new List<IShape>
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Triangle(3, 4, 5),
                new Rectangle(4, 4)
            };

            PrintShapesInfo(shapes);
            Console.ReadLine();
        }
    }
}
