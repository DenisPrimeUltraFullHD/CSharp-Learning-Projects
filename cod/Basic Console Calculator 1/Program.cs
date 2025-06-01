using System;

namespace cod
{
    class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
    class Program
    {
        static void Main()
        {
            var Calculator = new Calculator();

            string work = "";

            while (true)
            {
                System.Console.WriteLine("\nВведите какое число хотите ввести?(Целое(0) Дробовое(1))\nДля выхода введите break:");
                string operation = Console.ReadLine();
                if (operation != "0" && operation != "1" && operation != "break")
                    break;

                if (operation == "break")
                    break;

                System.Console.WriteLine("Введите числа.");
                string num1 = Console.ReadLine();
                string num2 = Console.ReadLine();

                System.Console.WriteLine("Какую операцию хотите выполнить?(+, , *, /)");
                string operation_on_calc = Console.ReadLine();
                if (operation == "0")
                {
                    int number1 = int.Parse(num1);
                    int number2 = int.Parse(num2);
                    int result = 0;
                    switch (operation_on_calc)
                    {
                        case "+":
                            result = Calculator.Add(number1, number2);
                            break;

                        case "-":
                            result = Calculator.Subtract(number1, number2);
                            break;

                        case "*":
                            result = Calculator.Multiply(number1, number2);
                            break;

                        case "/":
                            result = Calculator.Divide(number1, number2);
                            break;

                        default:
                            System.Console.WriteLine("Введите существующую операцию!");
                            operation_on_calc = Console.ReadLine();
                            continue;
                    }
                    System.Console.WriteLine($"Результат операции: {result}");
                }
                if (operation == "1")
                {
                    double number1 = double.Parse(num1);
                    double number2 = double.Parse(num2);
                    double result = 0;
                    switch (operation_on_calc)
                    {
                        case "+":
                            result = Calculator.Add(number1, number2);
                            break;

                        case "-":
                            result = Calculator.Subtract(number1, number2);
                            break;

                        case "*":
                            result = Calculator.Multiply(number1, number2);
                            break;

                        case "/":
                            result = Calculator.Divide(number1, number2);
                            break;

                        default:
                            System.Console.WriteLine("Введите существующую операцию!");
                            operation_on_calc = Console.ReadLine();
                            continue;
                    }
                    System.Console.WriteLine($"Результат операции: {result}");
                }
            }
        }
    }
}