using System;

namespace cod
{
    struct Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    class Point2DRef
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var point2d = new Point2D { X = 10.1, Y = 20.2 };
            var point2dref = new Point2DRef { X = 10.1, Y = 20.2 };

            var point2dCopy = point2d;
            var point2drefCopy = point2dref;

            point2dCopy.X = 5.5;
            point2drefCopy.X = 5.5;


            Console.WriteLine($"Original struct: X = {point2d.X}, Y = {point2d.Y}");
            Console.WriteLine($"Modified struct copy: X = {point2dCopy.X}, Y = {point2dCopy.Y}");
            Console.WriteLine($"Original class:  X = {point2dref.X}, Y = {point2dref.Y}");
            Console.WriteLine($"Modified class copy:  X = {point2drefCopy.X}, Y = {point2drefCopy.Y}");
        }
    }
}
