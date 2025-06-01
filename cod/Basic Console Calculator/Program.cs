using System;

namespace cod
{

    public class Calculator
    {

        public static int Add(int a, int b)
        {
            int sum = a + b;
            System.Console.WriteLine(a + " + " + b + " = " + sum);
            return sum;
        }
        public static int Subtract(int a, int b)
        {
            int sum = a - b;
            System.Console.WriteLine(a + " - " + b + " = " + sum);
            return sum;
        }
        public static int Multiply(int a, int b)
        {
            int sum = a * b;
            System.Console.WriteLine(a + " * " + b + " = " + sum);
            return sum;
        }
        public static int Divide(int a, int b)
        {
            int sum = a / b;
            System.Console.WriteLine(a + " / " + b + " = " + sum);
            return sum;
        }
    }
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Введите 1 число ");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Введите 2 число ");
            int b = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Какую операцию выполнить? ");
            string operation = Console.ReadLine();


            switch (operation)
            {

                case "+":
                    Calculator.Add(a, b);
                    break;

                case "-":
                    Calculator.Subtract(a, b);
                    break;

                case "*":
                    Calculator.Multiply(a, b);
                    break;

                case "/":
                    Calculator.Divide(a, b);
                    break;

                default:
                    System.Console.WriteLine("Error");
                    break;
            }
        }
    }
}