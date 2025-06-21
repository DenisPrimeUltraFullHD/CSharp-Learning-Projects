using System;

namespace cod

{
    class Program
    {
        static void Main()
        {  
            Console.WriteLine("Число? ");
            double a = Convert.ToDouble(Console.ReadLine());

            if(a % 2 == 0)
                Console.WriteLine("Чётное");
            else
                Console.WriteLine("Нечётное");


        }
    }   
}