using System;

namespace cod
{
    class Program
    {
        //Числа фибоначи
        static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main()
        {
            System.Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());
            num = Fibonacci(num);
            System.Console.WriteLine(num);

        }
    }
}