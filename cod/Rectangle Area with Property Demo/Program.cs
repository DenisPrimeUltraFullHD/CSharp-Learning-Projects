using System;
using System.IO;

namespace cod
{
    public class Rectangle
    {

        public int Width;

        public int Height;

        public int area
        {
            get { return Width * Height; }
        }

        public Rectangle(int _Width, int _Height)
        {
            Width = _Width;

            Height = _Height;

        }
    }
    public class Program
    {
        public static void Main()
        {
            Rectangle rectangle0 = new Rectangle(12, 12);

            Rectangle rectangle1 = new Rectangle(12, 10);

            Console.WriteLine($"Площадь {rectangle0} = {rectangle0.area}");
            Console.WriteLine($"Площадь {rectangle1} = {rectangle1.area}");
        }
    }

}
