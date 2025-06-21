using System;

namespace cod

{
    class Program
    {
        static void Main()
        {
            int sum = 0;

            int[] mass = new int[10];

            Random random = new Random();

            for (int k = 0; k < mass.Length; k++)

            {
                mass[k] = random.Next(-100, 100);
            }

            foreach (int elements in mass)

            {
                sum += elements;
            }

            System.Console.WriteLine("Sum: " + sum);



        }
    }
}
