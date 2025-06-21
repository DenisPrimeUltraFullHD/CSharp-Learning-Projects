using System;

namespace cod
{
    class Program
    {
        static void Main()
        {

            string numstr = "10";

            bool num = int.TryParse(numstr, out int result);

            if (num)
                System.Console.WriteLine("Это число");
            else
                System.Console.WriteLine("Это не число");






        }
    }
}