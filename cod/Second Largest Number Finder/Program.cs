using System;

namespace cod
{
    class Program
    {
        static void Main()
        {  
            int[] numbers = new int[5] {1, 2, 3, 4, 5};

            if (numbers.Length < 2)
            {
                System.Console.WriteLine("Array must contain at least two distinct elements.");
                return;
            }

            int max = int.MinValue;
            int secondMax = int.MinValue;

            foreach (int num in numbers)
            {
                if (num > max)
                {
                    secondMax = max;
                    max = num;
                }
                else if (num > secondMax && num != max)
                {
                    secondMax = num;
                }
            }

            System.Console.WriteLine($"Самое большое число после максимального: {secondMax}");
        }
    }
}