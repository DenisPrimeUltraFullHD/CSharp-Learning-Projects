using System;

namespace cod
{
    enum AccessLevel { Guest, User, Moderator, Admin }

    class PrintPermissions
    {
        public void Print(AccessLevel level)
        {
            switch (level)
            {
                case AccessLevel.Guest:
                    Console.WriteLine("Доступ только для чтения.");
                    break;
                case AccessLevel.User:
                    Console.WriteLine("Доступ к чтению и комментированию.");
                    break;
                case AccessLevel.Moderator:
                    Console.WriteLine("Можно редактировать и удалять комментарии.");
                    break;
                case AccessLevel.Admin:
                    Console.WriteLine("Полный доступ ко всем функциям.");
                    break;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите уровень доступа (Guest, User, Moderator, Admin): ");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, out AccessLevel level))
            {
                PrintPermissions permissions = new PrintPermissions();
                permissions.Print(level);
            }
            else
            {
                Console.WriteLine("Неверный уровень доступа.");
            }
        }
    }
}


// ✅ Задача 2: Уровни доступа

// Создай перечисление AccessLevel со значениями: Guest, User, Moderator, Admin.

// Напиши метод PrintPermissions(AccessLevel level), который в зависимости от уровня доступа выводит:

//     Guest: "Доступ только для чтения."

//     User: "Доступ к чтению и комментированию."

//     Moderator: "Можно редактировать и удалять комментарии."

//     Admin: "Полный доступ ко всем функциям."

// В Main() протестируй метод с каждым уровнем.