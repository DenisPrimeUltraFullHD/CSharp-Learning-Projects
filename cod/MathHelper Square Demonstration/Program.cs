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
/*
Задача 3: Статический метод для вычисления

Описание:
Напишите класс MathHelper, который содержит:

    Статический метод Square(int number), возвращающий квадрат переданного числа.

    Статический конструктор, который выводит сообщение о том, что класс MathHelper загружен (для демонстрации работы статического конструктора).

В методе Main() вызовите статический метод Square и выведите результат.

Подсказки:

    Объявите статический метод следующим образом:

public static int Square(int number) { ... }

Статический конструктор не принимает параметров и автоматически вызывается перед первым обращением к классу.

Поскольку метод и конструктор статические, обращаться к ним можно без создания экземпляра класса.
*/