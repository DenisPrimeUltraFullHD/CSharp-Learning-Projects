using System;

namespace cod
{
    class Program
    {
        static int SumArray(int[] arr, int index = 0)
        {
            if (index >= arr.Length)
                return 0;
            else
                return arr[index] + SumArray(arr, index + 1);

        }
        static void Main()
        {
            int[] arr =
            {
                1,2,3,4,5,6,7,8,9,10
            };
            int res = SumArray(arr);
            System.Console.WriteLine(res);
        }
    }
}