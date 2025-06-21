using System;

namespace cod

{
    class Program
    {
        static void Main()
        {  
            Console.WriteLine("Ведите радиус круга: ");  
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            System.Console.WriteLine($"Площадь круга с радиусом {radius} равна {area}");

        }

    }   
}