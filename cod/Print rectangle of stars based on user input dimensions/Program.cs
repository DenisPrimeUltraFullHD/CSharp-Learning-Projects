using System;

namespace cod
{
    class Program
    {
        static void Main()
        {

            System.Console.WriteLine("Введите длину прямоугольника");
            int row = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Введите ширину прямоугольника");
            int col = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
    }
}