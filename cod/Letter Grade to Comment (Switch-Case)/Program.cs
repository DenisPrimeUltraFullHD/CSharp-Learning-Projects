using System;

namespace cod

{
    class Program
    {
        static void Main()
        {  
            Console.WriteLine("Введите оценку: ");
            string a = Console.ReadLine().ToUpper();

            switch(a)
            {    
                case "A":
                    Console.WriteLine("Отлично "); break;
                case "B":
                    Console.WriteLine("Хорошо "); break;
                case "C":
                    Console.WriteLine("Удовлетворительно "); break;
                case "D":
                    Console.WriteLine("Плохо "); break;
                case "F":
                    Console.WriteLine("Неудовлетворительно "); break;
                default:
                    Console.WriteLine("Ошибка введите правильную букву"); break;
            }
        }
    }   
}

/*
Описание:
Создай программу, которая запрашивает у пользователя ввод буквы оценки (например, A, B, C, D, F) и выводит комментарий:

A – "Отлично"

B – "Хорошо"

C – "Удовлетворительно"

D – "Плохо"

F – "Неудовлетворительно"
Если введена неверная буква, выведите сообщение об ошибке.
Подсказка:
Используй switch-case для обработки разных вариантов.
*/