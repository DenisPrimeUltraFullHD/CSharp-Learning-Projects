using System;

namespace cod
{
    class Program
    {
        static void Main()
        {  
            byte[] numbers1 = { 2, 31, 42, 51, 65, 76 };
            int result1 = Sum(numbers1);
            System.Console.WriteLine("Результат для numbers1: " + result1);

            byte[] numbers2 = { 4, 31, 42, 51, 65, 76 };
            int result2 = Sum(numbers2);
            System.Console.WriteLine("Результат для numbers2: " + result2);
        }

        public static int Sum(byte[] digits)
        {
            int sum = 0;
            foreach (byte el in digits)
            {
                sum += el;    
            }
            return sum;
        }
    }
}
