using System;

namespace cod
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();

            System.Console.WriteLine("Введите размер массива.");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10000);
                System.Console.WriteLine(array[i]);
            }
            int min = array[0];
            int max = array[0];
            int sum = 0;
            int even = 0;
            int odd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                else if (array[i] > max)
                {
                    max = array[i];
                }
                sum += array[i];
                if (array[i] % 2 == 0)
                {
                    even++;
                }
                else if (array[i] % 2 != 0)
                {
                    odd++;
                }

            }
            int average = sum / n;
            System.Console.WriteLine($"\nmax {max}, min {min}, sum {sum}, average {average}, even {even}, odd {odd}");
        }
    }
}