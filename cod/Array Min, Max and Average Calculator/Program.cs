using System;

namespace cod

{
    class Program
    {
        static void Main()
        {  

            int i = 0;

            int[] mass = new int[10];

            for(i = 0; i < mass.Length; i++)
            {
                Console.WriteLine($"Введите число {i} : ");

                mass[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int max = 0; max < mass.Length; max++)
            {
                if(mass[max] > mass[0])
                {
                    mass[0] = mass[max];
                }
            }
            Console.WriteLine($"Максимальное число в массиве: {mass[0]}");

            for(int min = 0; min < mass.Length; min++)
            {
                if(mass[min] < mass[0])
                {
                    mass[0] = mass[min];
                }
            }
            Console.WriteLine($"Минимальное число в массиве: {mass[0]}");

            int sum = 0;

            double average = 0;

            for(int j = 0; j < mass.Length; j++)
            {
                if(j < mass.Length)
                {
                    
                    sum += mass[j];

                    mass[0] = sum / mass.Length;

                }
            }

            Console.WriteLine($"Среднее арифметическое: {mass[0]}");
        }
    }
}
