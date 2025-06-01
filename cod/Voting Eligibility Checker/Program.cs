using System;

namespace cod

{
    class Program
    {
        static void Main()
        {  
            Console.WriteLine("Ваш возраст: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if(a >= 18)
                Console.WriteLine("Вы можете голосовать!");
            else
                Console.WriteLine("Голосовать только с 18 лет!");




        }
    }   
}