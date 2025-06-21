using System;

namespace cod
{
    static class MathHelpers
    {
        public static int Square(int x)
        {
            return x * x;
        }
        public static bool IsEven(int x)
        {
            if (x % 2 == 0)
                return true;
            else
                return false;
        }
        public static double Hypotenuse(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }
    }
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Выберите операцию: 1-Квадрат числа, 2-Парность числа, 3-Узнать Гипотенузу");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    int num0;
                    System.Console.WriteLine("Введите число");
                    num0 = int.Parse(Console.ReadLine());
                    int Result = MathHelpers.Square(num0);
                    System.Console.WriteLine(Result);
                    break;

                case "2":
                    int num1;
                    System.Console.WriteLine("Введите число");
                    num1 = int.Parse(Console.ReadLine());
                    bool result = MathHelpers.IsEven(num1);
                    if (result == true)
                        System.Console.WriteLine("Парное!");
                    else
                        System.Console.WriteLine("Не парное!");
                    break;

                case "3":
                    double num2;
                    double num3;
                    System.Console.WriteLine("Введите числа");
                    num2 = double.Parse(Console.ReadLine());
                    num3 = double.Parse(Console.ReadLine());
                    double res = MathHelpers.Hypotenuse(num2, num3);
                    System.Console.WriteLine(res);
                    break;

                default:
                    break;
            }
        }
    }

}