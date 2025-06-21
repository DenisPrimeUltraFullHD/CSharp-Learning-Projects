using System;

namespace cod
{

    class FactorialCalculator
    {

        static public int RecursiveFactorial(int fak)
        {
            if (fak <= 1)
                return 1;
            else
                return fak * RecursiveFactorial(fak - 1);
        }
        public static int IterativeFactorial(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
    class Program
    {
        static void Main()
        {
            int result = 0;
            System.Console.WriteLine("Какую задачу хотите выполнить? (RF, IF)");
            string operation = System.Console.ReadLine();

            System.Console.WriteLine("Ведите число факториала: ");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case "RF":
                    result = FactorialCalculator.RecursiveFactorial(a);
                    System.Console.WriteLine($"факториал {a} = {result}");
                    break;

                case "IF":
                    result = FactorialCalculator.IterativeFactorial(a);
                    System.Console.WriteLine($"факториал {a} = {result}");
                    break;

            }
        }
    }
}