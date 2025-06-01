using System;

namespace cod
{
    class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }


        static void Main()
        {

            int X = 5;
            int Y = 6;

            Swap(ref X, ref Y);


            System.Console.WriteLine(X + " " + Y);





        }
    }
}