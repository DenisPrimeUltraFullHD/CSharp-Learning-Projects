using System;

namespace cod
{
    class Program

    {
        public static double? CalculateAverage(int?[] values)
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].HasValue) { sum += values[i].Value; count++; }
            }
            if (count == 0)
                return null;
            return sum / count;
        }

        static void Main()
        {
            int?[] values = new int?[5];
            for (int i = 0; i < values.Length; i++)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    values[i] = null;
                else
                    values[i] = int.Parse(input);
            }

            double? result = CalculateAverage(values);

            if (result.HasValue)
                Console.WriteLine($"Среднее = {result.Value:F2}");
            else
                Console.WriteLine("Ни одного числа не было введено — среднее не вычислить");
        }
    }
}