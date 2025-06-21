using System;

namespace cod
{
    class Rectangle
    {
        private double width;
        private double height;

        public void SetSize(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetArea()
        {
            return this.width * this.height;
        }

        public double GetPerimeter()
        {
            return 2 * (this.width + this.height);
        }
    }
    class Program
    {
        static void Main()
        {
            var rect = new Rectangle();

            double width = 23.2;
            double height = 32.5;

            rect.SetSize(width, height);

            double area = rect.GetArea();
            double perimeter = rect.GetPerimeter();

            System.Console.WriteLine(area);
            System.Console.WriteLine(perimeter);
        }
    }
}