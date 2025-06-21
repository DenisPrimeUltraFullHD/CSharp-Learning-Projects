using System;

namespace cod
{
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }
    }
    public class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }
        public Triangle(double baselength, double height)
        {
            BaseLength = baselength;
            Height = height;
        }
        public override double Area()
        {
            return 0.5 * BaseLength * Height;
        }
    }
    class Program
    {
        static void Main()
        {
            static void PrintArea(Shape shape)
            {
                Console.WriteLine($"{shape.GetType().Name}: площадь = {shape.Area()}");
            }
            var rectangle = new Rectangle(10, 5);
            var circle = new Circle(55);
            var triangle = new Triangle(10, 10);

            Shape[] shapes = { rectangle, circle, triangle };

            foreach (var shape in shapes)
                PrintArea(shape);

        }
    }
}