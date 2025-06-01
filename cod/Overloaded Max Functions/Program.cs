using System;

namespace cod
{
    class Program
    {

        static int Max(int a, int b)
        {
            if (a < b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        static int Max(int a, int b, int c)
        {
            if (a < b && b > c)
            {
                return b;
            }
            else if (a < c && b < c)
            {
                return c;
            }
            else
            {
                return a;
            }
        }
        static double Max(double x, double y)
        {
            if (x < y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }
        static int Max(int[] numbers)
        {
            int max = numbers[0];
            foreach (int item in numbers)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        static void Main()
        {
            int int1 = 9;
            int int2 = 67;
            int int3 = 68;

            double double1 = 3.3;
            double double2 = 9.9;

            int[] int4 = { 12, 412, 51, 434, 5234, 6324, 245, 324, 124 };

            System.Console.WriteLine(Max(int1, int2));
            System.Console.WriteLine(Max(int1, int2, int3));
            System.Console.WriteLine(Max(double1, double2));
            System.Console.WriteLine(Max(int4));
        }
    }
}