using System;

namespace cod
{
    class Program
    {
        static int Gcd(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return Gcd(b, a % b);

        }

        static void Main()
        {
            System.Console.WriteLine("Введите числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int res = Gcd(a, b);
            System.Console.WriteLine(res);
        }
    }
}