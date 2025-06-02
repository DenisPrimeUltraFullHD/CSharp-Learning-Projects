using System;

namespace cod
{
    public class MathHelper
        {   

        public static int Square(int number)

        {
            
        return number * number;

        }

        static MathHelper()
        {
            System.Console.WriteLine("Класс MathHelp Загружен");
        }

        
        }
    public class Program
    {
        public static void Main()
        {  
           int result = MathHelper.Square(5);

           System.Console.WriteLine($"Квадрат {result} "); 

           int result1 = MathHelper.Square(2);

           System.Console.WriteLine($"Квадрат {result1} "); 

           int result2 = MathHelper.Square(7);

           System.Console.WriteLine($"Квадрат {result2} "); 
           
           int result3 = MathHelper.Square(6);

           System.Console.WriteLine($"Квадрат {result3} "); 

           int result4 = MathHelper.Square(12);

           System.Console.WriteLine($"Квадрат {result4} "); 

        }
    }      
}
