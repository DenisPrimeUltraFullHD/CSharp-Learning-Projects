using System;

namespace cod
{
    class Program
    {
        static void Print(int num)
        {
            Console.WriteLine(num);
        }
        static void Print(string word)
        {
            System.Console.WriteLine(word);
        }
        static void Print(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                System.Console.Write($"{mass[i]}\t");
            }
        }
        static void Main()
        {
            int a = 2;
            string jopa = "jopa";
            int[] arr = { 1, 2, 3, 4 };

            Print(a);
            Print(jopa);
            Print(arr);

        }
    }
}