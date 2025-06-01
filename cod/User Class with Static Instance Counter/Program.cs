using System;

namespace cod
{
    class User
    {
        public string Name { get; }
        public static int TotalUsers;

        public User(string name)
        {
            Name = name;
            TotalUsers++;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"User: {Name}, created. Всіх користувачів: {TotalUsers}");
        }

        public static void PrintTotalUsers()
        {
            Console.WriteLine($"Загалом створено користувачів: {TotalUsers}");
        }
    }

    class Program
    {
        static void Main()
        {
            User.PrintTotalUsers();

            var u1 = new User("Вова");
            u1.PrintInfo();

            var u2 = new User("Оля");
            u2.PrintInfo();

            User.PrintTotalUsers();
        }
    }
}
