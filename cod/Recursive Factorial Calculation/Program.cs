using System;

namespace cod
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        static void Main()
        {
            int num = Factorial(5);
            System.Console.WriteLine(num);
        }
    }
}