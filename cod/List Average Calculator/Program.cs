using System;
using System.Collections.Generic;

namespace cod

{
    class Program
    {
        static void Main()
        {

            double sum = 0;

            List<double> nums = new List<double>
        {
            4.2, 6.1, 7.4, 8.7, 9.8, 12.3, 14.6,
        };

            foreach (double elements in nums)
            {
                sum += elements;
            }

            System.Console.WriteLine(nums.Count);
            System.Console.WriteLine(sum);

            double avg = (sum / nums.Count);

            System.Console.WriteLine("avg: " + avg);
        }
    }
}
