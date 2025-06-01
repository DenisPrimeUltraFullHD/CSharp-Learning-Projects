using System;

namespace cod
{
    class Program
    {
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
        static void Main()
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;

            double num4 = 2.7;
            double num5 = 3.7;

            System.Console.WriteLine(Sum(num1, num2));
            System.Console.WriteLine(Sum(num1, num2, num3));
            System.Console.WriteLine(Sum(num4, num5));
        }
    }
}