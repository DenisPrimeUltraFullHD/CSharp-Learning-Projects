using System;

namespace cod

{
    class Program
    {
        static void Main()
        {  

            int[] numbers = new int[10];

            

            for(int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"Ведіть число індекс({i}) для запису в масиву: ");

                numbers [i] = Convert.ToInt32(Console.ReadLine());

            }

            int max = numbers[0];

            for(int i1 = 1; i1 < numbers.Length; i1++)
            {
                if(numbers[i1] > max)
                {
                    max = numbers[i1];
                }
            }

            System.Console.WriteLine($"Самое большое число в массиве: {max}");
        }
    }  
}
