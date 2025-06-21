using System;

namespace cod

{
    class Program
    {
        static void Main()
        {  
            Console.WriteLine("Введите число (от 1 до 12): ");
            short a = Convert.ToInt16(Console.ReadLine());

            switch(a)
            {    
                case 1: case 12: case 2:
                    Console.WriteLine("Зима "); break;
                case 3: case 4: case 5:
                    Console.WriteLine("Весна "); break;
                case 6: case 7: case 8:
                    Console.WriteLine("Літо "); break;
                case 9: case 10: case 11:
                    Console.WriteLine("Осінь "); break;
                default:
                    Console.WriteLine("Ошибка: введите число от 1 до 12."); break;
            }
        }
    }   
}
