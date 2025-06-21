using System;

namespace cod
{
    class Program
    {

        static int Factorial(int n)
        {
            if (n == 0)
                return n = 1;
            else
                return Factorial(n - 1) * n;
        }
        static void Main()
        {
            System.Console.WriteLine("Введите число факториала: ");
            int n = int.Parse(Console.ReadLine());

            n = Factorial(n);

            System.Console.WriteLine(n);
        }
    }
}