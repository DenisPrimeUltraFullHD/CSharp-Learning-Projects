using System;

namespace cod

{
    class Program
    {
        static void Main()
        {
            string password;

            do
            {
                Console.WriteLine("Введіть пароль ");
                password = Console.ReadLine() ?? "";

            }

            while (password != "zxc");

            Console.WriteLine("Авторизація успішна!");




        }
    }
}