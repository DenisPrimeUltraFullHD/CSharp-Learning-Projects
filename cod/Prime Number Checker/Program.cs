using System;

namespace cod
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (IsPrime(i) == true)
                    System.Console.WriteLine($"Число {i} простое");

                if (IsPrime(i) == false)
                    System.Console.WriteLine($"Число {i} НЕ простое");
            }
        }
    }
}