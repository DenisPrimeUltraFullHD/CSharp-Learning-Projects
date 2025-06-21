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
                System.Console.WriteLine("Ведите пароль");
                password = Console.ReadLine();

            } while (password != "1234");



            System.Console.WriteLine("Пароль верный");
        }
    }
}